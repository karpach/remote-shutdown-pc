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
            this.chkAutoLoad.Location = new System.Drawing.Point(12, 12);
            this.chkAutoLoad.Name = "chkAutoLoad";
            this.chkAutoLoad.Size = new System.Drawing.Size(168, 17);
            this.chkAutoLoad.TabIndex = 1;
            this.chkAutoLoad.Text = "Auto load at Windows startup:";
            this.chkAutoLoad.UseVisualStyleBackColor = true;            
            // 
            // lbDefaultCommand
            // 
            this.lbDefaultCommand.AutoSize = true;
            this.lbDefaultCommand.Location = new System.Drawing.Point(43, 40);
            this.lbDefaultCommand.Name = "lbDefaultCommand";
            this.lbDefaultCommand.Size = new System.Drawing.Size(118, 13);
            this.lbDefaultCommand.TabIndex = 2;
            this.lbDefaultCommand.Text = "System Tray Command:";
            // 
            // cbxTrayCommand
            // 
            this.cbxTrayCommand.FormattingEnabled = true;
            this.cbxTrayCommand.Location = new System.Drawing.Point(166, 37);
            this.cbxTrayCommand.Name = "cbxTrayCommand";
            this.cbxTrayCommand.Size = new System.Drawing.Size(121, 21);
            this.cbxTrayCommand.TabIndex = 3;            
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(83, 146);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(166, 146);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lbSecretCode
            // 
            this.lbSecretCode.AutoSize = true;
            this.lbSecretCode.Location = new System.Drawing.Point(92, 73);
            this.lbSecretCode.Name = "lbSecretCode";
            this.lbSecretCode.Size = new System.Drawing.Size(69, 13);
            this.lbSecretCode.TabIndex = 2;
            this.lbSecretCode.Text = "Secret Code:";
            // 
            // txtSecretCode
            // 
            this.txtSecretCode.Location = new System.Drawing.Point(166, 70);
            this.txtSecretCode.Name = "txtSecretCode";
            this.txtSecretCode.Size = new System.Drawing.Size(121, 20);
            this.txtSecretCode.TabIndex = 5;
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(132, 105);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(29, 13);
            this.lbPort.TabIndex = 2;
            this.lbPort.Text = "Port:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(166, 102);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(121, 20);
            this.txtPort.TabIndex = 5;
            this.txtPort.Validating += new System.ComponentModel.CancelEventHandler(this.txtPort_Validating);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 184);
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