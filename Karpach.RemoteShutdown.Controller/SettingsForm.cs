using System;
using System.Windows.Forms;

namespace Karpach.RemoteShutdown.Controller
{
    public partial class SettingsForm : Form
    {
        public TrayCommandType CommandType { get; set; }
        public bool AutoStart { get; set; }

        public SettingsForm()
        {
            InitializeComponent();                        
            cbxTrayCommand.DisplayMember = "Name";
            cbxTrayCommand.ValueMember = "CommandType";
            cbxTrayCommand.DataSource = TrayCommandHelper.Commands;
        }

        private void TrayCommandSelectedIndexChanged(object sender, EventArgs e)
        {
            CommandType = (TrayCommandType)cbxTrayCommand.SelectedValue;
        }

        private void chkAutoLoad_CheckedChanged(object sender, EventArgs e)
        {
            AutoStart = chkAutoLoad.Checked;
        }
    }
}
