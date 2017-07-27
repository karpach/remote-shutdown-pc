using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Karpach.RemoteShutdown.Controller.Properties;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Karpach.RemoteShutdown.Controller
{
    public class ControllerApplicationContext: ApplicationContext
    {
        private readonly NotifyIcon _trayIcon;
        private readonly CancellationTokenSource _cancellationTokenSource;

        public ControllerApplicationContext()
        {
            _cancellationTokenSource = new CancellationTokenSource();            
            var notifyContextMenu = new ContextMenuStrip();

            var hibernate = new ToolStripMenuItem("Hibernate")
            {
                Image = Resources.Shutdown.ToBitmap()
            };
            hibernate.Click += Hibernate;
            notifyContextMenu.Items.Add(hibernate);

            notifyContextMenu.Items.Add("-");

            var exit = new ToolStripMenuItem("Exit")
            {
                Image = Resources.Exit.ToBitmap()
            };
            exit.Click += Exit;
            notifyContextMenu.Items.Add(exit);


            // Initialize Tray Icon            
            _trayIcon = new NotifyIcon
            {
                Icon = Resources.AppIcon,
                ContextMenuStrip = notifyContextMenu,
                Visible = true
            };
            Task.Run(() =>
            {
                var host = new WebHostBuilder()                                                            
                    .UseUrls($"http://+:{Settings.Default.RemotePort}")
                    .UseKestrel()
                    .Configure(app =>
                    {
                        app.Run(async context =>
                        {
                            Hibernate(this,null);    
                            context.Response.StatusCode = 204;
                            await Task.Yield();
                        });
                    })
                    .Build();
                host.Run();
            }, _cancellationTokenSource.Token);
        }

        private void Hibernate(object sender, EventArgs e)
        {
            Application.SetSuspendState(PowerState.Hibernate, true, true);
        }

        void Exit(object sender, EventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            _trayIcon.Visible = false;            
            _cancellationTokenSource.Cancel();
            Application.Exit();
        }        
    }
}