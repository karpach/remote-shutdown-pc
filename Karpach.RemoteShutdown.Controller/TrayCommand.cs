using System.Windows.Forms;

namespace Karpach.RemoteShutdown.Controller
{
    public class TrayCommand
    {
        public TrayCommandType CommandType { get; set; }
        public string Name { get; set; }
    }
}