using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Karpach.RemoteShutdown.Controller.Interfaces;

namespace Karpach.RemoteShutdown.Controller.Helpers
{
    public class TrayCommandHelper : ITrayCommandHelper
    {
        private TrayCommand[] _commands;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(
            IntPtr hWnd,
            UInt32 msg,
            IntPtr wParam,
            IntPtr lParam
        );

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern bool LockWorkStation();

        public TrayCommand[] Commands => _commands ?? (_commands = new[]
        {
            new TrayCommand {CommandType = TrayCommandType.Hibernate, Name = "Hibernate"},
            new TrayCommand {CommandType = TrayCommandType.TurnScreenOff, Name = "Turn screen off"},
            new TrayCommand {CommandType = TrayCommandType.Suspend, Name = "Suspend"},
            new TrayCommand {CommandType = TrayCommandType.Shutdown, Name = "Shutdown"},
            new TrayCommand {CommandType = TrayCommandType.ForceShutdown, Name = "Force Shutdown"},
            new TrayCommand {CommandType = TrayCommandType.Lock, Name = "Lock" }
        });

        public string GetText(TrayCommandType commandType)
        {
            return Commands.SingleOrDefault(c => c.CommandType == commandType)?.Name;
        }

        public TrayCommandType? GetCommandType(string commandName)
        {
            return Commands.SingleOrDefault(c => string.Equals(c.Name, commandName, StringComparison.InvariantCultureIgnoreCase))?.CommandType;
        }

        public void RunCommand(TrayCommandType commandType)
        {            
            switch (commandType)
            {
                case TrayCommandType.Hibernate:
                    Application.SetSuspendState(PowerState.Hibernate, true, true);
                    break;
                case TrayCommandType.Shutdown:
                    Process.Start("shutdown", "/s /t 0");
                    break;
                case TrayCommandType.Suspend:
                    Application.SetSuspendState(PowerState.Suspend, true, true);
                    break;
                case TrayCommandType.TurnScreenOff:
                    SendMessage(
                        (IntPtr)0xffff, // HWND_BROADCAST
                        0x0112,         // WM_SYSCOMMAND
                        (IntPtr)0xf170, // SC_MONITORPOWER
                        (IntPtr)0x0002  // POWER_OFF
                    );
                    break;
                case TrayCommandType.ForceShutdown:
                    Process.Start("shutdown", "/s /f /t 10");
                    break;
                case TrayCommandType.Lock:
	                LockWorkStation();
	                break;
            }
        }
    }
}