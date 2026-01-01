using System.Windows.Forms;

namespace Karpach.RemoteShutdown.Controller.Interfaces
{
    public interface IDelayForm
    {
        TrayCommandType CommandType { get; set; }
        int Delay { get; set; }
        DialogResult ShowDialog();
    }
}
