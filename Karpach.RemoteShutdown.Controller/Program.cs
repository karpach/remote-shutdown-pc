using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using Karpach.RemoteShutdown.Controller.Helpers;
using Karpach.RemoteShutdown.Controller.Interfaces;

namespace Karpach.RemoteShutdown.Controller
{
    static class Program
    {
        public static IContainer Container { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<TrayCommandHelper>().As<ITrayCommandHelper>().SingleInstance();
            builder.RegisterType<ControllerApplicationContext>().AsSelf();
            builder.RegisterType<SettingsForm>().AsSelf();
            builder.RegisterType<DelayForm>().As<IDelayForm>().AsSelf();
            builder.RegisterType<HostHelper>().As<IHostHelper>();
            Container = builder.Build();
            Application.EnableVisualStyles();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Container.Resolve<ControllerApplicationContext>());
        }
    }
}
