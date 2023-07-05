using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Karpach.RemoteShutdown.Controller.Interfaces;
using Karpach.RemoteShutdown.Controller.Properties;

namespace Karpach.RemoteShutdown.Controller
{
    public partial class DelayForm : Form
    {
        private readonly ITrayCommandHelper _trayCommandHelper;
        public TrayCommandType CommandType { get; set; }
        public int Delay { get; set; }

        public DelayForm(ITrayCommandHelper trayCommandHelper)
        {
            _trayCommandHelper = trayCommandHelper;

            InitializeComponent();
        }

        protected async override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            //this.BringToFront()
            this.Focus();

            for(int i = Delay; i > 0; i--)
            {
                labelDelay.Text = $"Operation '{_trayCommandHelper.GetText(CommandType)}' is delayed for {i} seconds.";

                await Task.Delay(1000);
            }


            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
