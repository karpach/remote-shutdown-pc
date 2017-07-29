using System.Threading.Tasks;

namespace Karpach.RemoteShutdown.Controller.Interfaces
{
    public interface IHostHelper
    {
        Task CreateHostAsync(int port);
        void Cancel();
        string SecretCode { get; set; }
        TrayCommandType DefaultCommand { get; set; }
    }
}