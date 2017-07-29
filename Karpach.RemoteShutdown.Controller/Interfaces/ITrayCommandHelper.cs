namespace Karpach.RemoteShutdown.Controller.Interfaces
{
    public interface ITrayCommandHelper
    {
        TrayCommand[] Commands { get; }
        string GetText(TrayCommandType commandType);
        void RunCommand(TrayCommandType commandType);
        TrayCommandType? GetCommandType(string commandName);
    }
}