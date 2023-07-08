using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Karpach.RemoteShutdown.Controller.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Karpach.RemoteShutdown.Controller.Helpers
{
    public class HostHelper : IHostHelper
    {
        private readonly ITrayCommandHelper _trayCommandHelper;
        private readonly DelayForm _delayForm;
        private CancellationTokenSource _cancellationTokenSource;
        private Task _hostTask;

        public string SecretCode { get; set; }
        public TrayCommandType DefaultCommand { get; set; }

        public HostHelper(ITrayCommandHelper trayCommandHelper, DelayForm delayForm)
        {
            _trayCommandHelper = trayCommandHelper;
            _delayForm = delayForm;
            _cancellationTokenSource = new CancellationTokenSource();
        }

        public async Task CreateHostAsync(int port)
        {
            if (_hostTask != null)
            {
                _cancellationTokenSource.Cancel();
                await _hostTask.ConfigureAwait(false);
                _cancellationTokenSource = new CancellationTokenSource();
            }
            _hostTask = Task.Run(() =>
            {
                var host = new WebHostBuilder()
                    .UseUrls($"http://+:{port}")
                    .UseKestrel()
                    .Configure(app =>
                    {
                        app.Run(async context =>
                        {
#pragma warning disable 4014
                            ProcessRequestAsync(context.Request.Path.Value, context.Request.Query);
#pragma warning restore 4014
                            await context.Response.WriteAsync("Ok");
                        });
                    })
                    .Build();
                host.StartAsync(_cancellationTokenSource.Token);                
            }, _cancellationTokenSource.Token);
        }

        public void Cancel()
        {
            _cancellationTokenSource.Cancel();
        }

        internal async Task ProcessRequestAsync(string url, IQueryCollection query)
        {
            await Task.Delay(1000).ConfigureAwait(false);
            if (!string.IsNullOrEmpty(SecretCode) && !url.StartsWith($"/{SecretCode}/"))
            {                
                return;
            }
            int lastSlashPosition = url.LastIndexOf("/", StringComparison.Ordinal);
            string commandName = String.Empty;
            if (lastSlashPosition >= 0 && url.Length > 1)
            {
                commandName = url.Substring(lastSlashPosition + 1);
            }
            TrayCommandType? commandType = _trayCommandHelper.GetCommandType(commandName);
            if (!string.IsNullOrEmpty(commandName) && commandType == null)
            {
                return;
            }
            commandType = commandType ?? DefaultCommand;

            bool runCommand = ProcessRequestDelayAsync(query, commandType.Value);
            if (runCommand)
            {
                _trayCommandHelper.RunCommand(commandType.Value);
            }
        }

        /// <summary>
        /// Check the the current request should be delayed. If so, display a modal
        /// </summary>
        /// <returns>True if the operation can continue. False if the user aborted the operation</returns>
        internal bool ProcessRequestDelayAsync(IQueryCollection query, TrayCommandType commandType)
        {
            if (query.ContainsKey("delay"))
            {
                string delayString = query["delay"][0];
                if (!int.TryParse(delayString, out int delay))
                {
                    return true;
                }

                _delayForm.CommandType = commandType;
                _delayForm.Delay = delay;
                DialogResult dialogResult = _delayForm.ShowDialog();

                if (dialogResult != DialogResult.OK)
                {
                    return false;
                }
            }

            return true;
        }
    }
}