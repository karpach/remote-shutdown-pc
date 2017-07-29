using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using Karpach.RemoteShutdown.Controller.Interfaces;

namespace Karpach.RemoteShutdown.Controller.Helpers
{
    public class TrayCommandHelper : ITrayCommandHelper
    {
        private TrayCommand[] _commands;

        public TrayCommand[] Commands => _commands ?? (_commands = new[]
        {
            new TrayCommand {CommandType = TrayCommandType.Hibernate, Name = "Hibernate"},
            new TrayCommand {CommandType = TrayCommandType.Suspend, Name = "Suspend"},
            new TrayCommand {CommandType = TrayCommandType.Shutdown, Name = "Shutdown"}
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
            }
        }
    }
}