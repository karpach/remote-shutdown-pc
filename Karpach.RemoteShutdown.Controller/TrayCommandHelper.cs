using System.Linq;

namespace Karpach.RemoteShutdown.Controller
{
    public class TrayCommandHelper
    {
        private static TrayCommand[] _commands;

        public static TrayCommand[] Commands => _commands ?? (_commands = new[]
        {
            new TrayCommand {CommandType = TrayCommandType.Hibernate, Name = "Hibernate"},
            new TrayCommand {CommandType = TrayCommandType.Suspend, Name = "Suspend"},
            new TrayCommand {CommandType = TrayCommandType.Shutdown, Name = "Shutdown"}
        });

        public static string GetText(TrayCommandType commandType)
        {
            return Commands.SingleOrDefault(c => c.CommandType == commandType).Name;
        }
    }
}