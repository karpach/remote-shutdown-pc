using System;
using System.Linq;
using System.Windows.Forms;
using Karpach.RemoteShutdown.Controller.Interfaces;
using Karpach.RemoteShutdown.Controller.Properties;

namespace Karpach.RemoteShutdown.Controller
{
    public partial class SettingsForm : Form
    {
        public TrayCommandType CommandType => (TrayCommandType) cbxTrayCommand.SelectedValue;
        public bool AutoStart => chkAutoLoad.Checked;
        public int Port => int.Parse(txtPort.Text);
        public string SecretCode => txtSecretCode.Text;

        public SettingsForm(ITrayCommandHelper trayCommandHelper)
        {
            InitializeComponent();
            txtSecretCode.Text = Settings.Default.SecretCode;
            txtPort.Text = Settings.Default.RemotePort.ToString();
            chkAutoLoad.Checked = Settings.Default.AutoStart;            
            cbxTrayCommand.DisplayMember = "Name";
            cbxTrayCommand.ValueMember = "CommandType";            
            cbxTrayCommand.DataSource = trayCommandHelper.Commands;
            cbxTrayCommand.SelectedItem = trayCommandHelper.Commands.SingleOrDefault(c => (int)c.CommandType == Settings.Default.DefaultCommand);
        }        

        private void txtPort_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int port;
            if (!int.TryParse(txtPort.Text, out port))
            {
                e.Cancel = false;
            }
        }
    }
}
