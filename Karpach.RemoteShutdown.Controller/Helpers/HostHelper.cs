using System;
using System.Threading;
using System.Threading.Tasks;
using Karpach.RemoteShutdown.Controller.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Karpach.RemoteShutdown.Controller.Helpers
{
    public class HostHelper : IHostHelper
    {
        private readonly ITrayCommandHelper _trayCommandHelper;
        private CancellationTokenSource _cancellationTokenSource;
        private Task _hostTask;

        public string SecretCode { get; set; }
        public TrayCommandType DefaultCommand { get; set; }

        public HostHelper(ITrayCommandHelper trayCommandHelper)
        {
            _trayCommandHelper = trayCommandHelper;
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
                            ProcessRequestAsync(context.Request.Path.Value);
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

        internal async Task ProcessRequestAsync(string url)
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
            _trayCommandHelper.RunCommand(commandType.Value);
        }
    }
}