namespace Karpach.RemoteShutdown.Controller
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			this.chkAutoLoad = new System.Windows.Forms.CheckBox();
			this.lbDefaultCommand = new System.Windows.Forms.Label();
			this.cbxTrayCommand = new System.Windows.Forms.ComboBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lbSecretCode = new System.Windows.Forms.Label();
			this.txtSecretCode = new System.Windows.Forms.TextBox();
			this.lbPort = new System.Windows.Forms.Label();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// chkAutoLoad
			// 
			this.chkAutoLoad.AutoSize = true;
			this.chkAutoLoad.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chkAutoLoad.Location = new System.Drawing.Point(21, 14);
			this.chkAutoLoad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.chkAutoLoad.Name = "chkAutoLoad";
			this.chkAutoLoad.Size = new System.Drawing.Size(186, 19);
			this.chkAutoLoad.TabIndex = 1;
			this.chkAutoLoad.Text = "Auto load at Windows startup:";
			this.chkAutoLoad.UseVisualStyleBackColor = true;
			// 
			// lbDefaultCommand
			// 
			this.lbDefaultCommand.AutoSize = true;
			this.lbDefaultCommand.Location = new System.Drawing.Point(50, 46);
			this.lbDefaultCommand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbDefaultCommand.Name = "lbDefaultCommand";
			this.lbDefaultCommand.Size = new System.Drawing.Size(132, 15);
			this.lbDefaultCommand.TabIndex = 2;
			this.lbDefaultCommand.Text = "System Tray Command:";
			// 
			// cbxTrayCommand
			// 
			this.cbxTrayCommand.FormattingEnabled = true;
			this.cbxTrayCommand.Location = new System.Drawing.Point(194, 43);
			this.cbxTrayCommand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.cbxTrayCommand.Name = "cbxTrayCommand";
			this.cbxTrayCommand.Size = new System.Drawing.Size(140, 23);
			this.cbxTrayCommand.TabIndex = 3;
			// 
			// btnOk
			// 
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(97, 168);
			this.btnOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(88, 27);
			this.btnOk.TabIndex = 4;
			this.btnOk.Text = "Ok";
			this.btnOk.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(194, 168);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(88, 27);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// lbSecretCode
			// 
			this.lbSecretCode.AutoSize = true;
			this.lbSecretCode.Location = new System.Drawing.Point(107, 84);
			this.lbSecretCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbSecretCode.Name = "lbSecretCode";
			this.lbSecretCode.Size = new System.Drawing.Size(73, 15);
			this.lbSecretCode.TabIndex = 2;
			this.lbSecretCode.Text = "Secret Code:";
			// 
			// txtSecretCode
			// 
			this.txtSecretCode.Location = new System.Drawing.Point(194, 81);
			this.txtSecretCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtSecretCode.Name = "txtSecretCode";
			this.txtSecretCode.Size = new System.Drawing.Size(140, 23);
			this.txtSecretCode.TabIndex = 5;
			// 
			// lbPort
			// 
			this.lbPort.AutoSize = true;
			this.lbPort.Location = new System.Drawing.Point(154, 121);
			this.lbPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lbPort.Name = "lbPort";
			this.lbPort.Size = new System.Drawing.Size(32, 15);
			this.lbPort.TabIndex = 2;
			this.lbPort.Text = "Port:";
			// 
			// txtPort
			// 
			this.txtPort.Location = new System.Drawing.Point(194, 118);
			this.txtPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(140, 23);
			this.txtPort.TabIndex = 5;
			this.txtPort.Validating += new System.ComponentModel.CancelEventHandler(this.txtPort_Validating);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(414, 212);
			this.Controls.Add(this.txtPort);
			this.Controls.Add(this.txtSecretCode);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.cbxTrayCommand);
			this.Controls.Add(this.lbPort);
			this.Controls.Add(this.lbSecretCode);
			this.Controls.Add(this.lbDefaultCommand);
			this.Controls.Add(this.chkAutoLoad);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.Name = "SettingsForm";
			this.Text = "Settings";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAutoLoad;
        private System.Windows.Forms.Label lbDefaultCommand;
        private System.Windows.Forms.ComboBox cbxTrayCommand;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbSecretCode;
        private System.Windows.Forms.TextBox txtSecretCode;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.TextBox txtPort;
    }
}