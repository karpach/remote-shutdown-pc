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
            chkAutoLoad = new System.Windows.Forms.CheckBox();
            lbDefaultCommand = new System.Windows.Forms.Label();
            cbxTrayCommand = new System.Windows.Forms.ComboBox();
            btnOk = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            lbSecretCode = new System.Windows.Forms.Label();
            txtSecretCode = new System.Windows.Forms.TextBox();
            lbPort = new System.Windows.Forms.Label();
            txtPort = new System.Windows.Forms.TextBox();
            txtFilename1 = new System.Windows.Forms.TextBox();
            lbFilename1 = new System.Windows.Forms.Label();
            txtFilename2 = new System.Windows.Forms.TextBox();
            lbFilename2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // chkAutoLoad
            // 
            chkAutoLoad.AutoSize = true;
            chkAutoLoad.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            chkAutoLoad.Location = new System.Drawing.Point(21, 15);
            chkAutoLoad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkAutoLoad.Name = "chkAutoLoad";
            chkAutoLoad.Size = new System.Drawing.Size(186, 19);
            chkAutoLoad.TabIndex = 1;
            chkAutoLoad.Text = "Auto load at Windows startup:";
            chkAutoLoad.UseVisualStyleBackColor = true;
            // 
            // lbDefaultCommand
            // 
            lbDefaultCommand.AutoSize = true;
            lbDefaultCommand.Location = new System.Drawing.Point(53, 48);
            lbDefaultCommand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbDefaultCommand.Name = "lbDefaultCommand";
            lbDefaultCommand.Size = new System.Drawing.Size(132, 15);
            lbDefaultCommand.TabIndex = 2;
            lbDefaultCommand.Text = "System Tray Command:";
            // 
            // cbxTrayCommand
            // 
            cbxTrayCommand.FormattingEnabled = true;
            cbxTrayCommand.Location = new System.Drawing.Point(194, 45);
            cbxTrayCommand.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cbxTrayCommand.Name = "cbxTrayCommand";
            cbxTrayCommand.Size = new System.Drawing.Size(140, 23);
            cbxTrayCommand.TabIndex = 3;
            // 
            // btnOk
            // 
            btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnOk.Location = new System.Drawing.Point(97, 222);
            btnOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnOk.Name = "btnOk";
            btnOk.Size = new System.Drawing.Size(88, 27);
            btnOk.TabIndex = 4;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Location = new System.Drawing.Point(194, 222);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(88, 27);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lbSecretCode
            // 
            lbSecretCode.AutoSize = true;
            lbSecretCode.Location = new System.Drawing.Point(112, 83);
            lbSecretCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbSecretCode.Name = "lbSecretCode";
            lbSecretCode.Size = new System.Drawing.Size(73, 15);
            lbSecretCode.TabIndex = 2;
            lbSecretCode.Text = "Secret Code:";
            // 
            // txtSecretCode
            // 
            txtSecretCode.Location = new System.Drawing.Point(194, 80);
            txtSecretCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtSecretCode.Name = "txtSecretCode";
            txtSecretCode.Size = new System.Drawing.Size(140, 23);
            txtSecretCode.TabIndex = 5;
            // 
            // lbPort
            // 
            lbPort.AutoSize = true;
            lbPort.Location = new System.Drawing.Point(154, 118);
            lbPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbPort.Name = "lbPort";
            lbPort.Size = new System.Drawing.Size(32, 15);
            lbPort.TabIndex = 2;
            lbPort.Text = "Port:";
            // 
            // txtPort
            // 
            txtPort.Location = new System.Drawing.Point(194, 115);
            txtPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtPort.Name = "txtPort";
            txtPort.Size = new System.Drawing.Size(140, 23);
            txtPort.TabIndex = 5;
            txtPort.Validating += txtPort_Validating;
            // 
            // txtFilename1
            // 
            txtFilename1.Location = new System.Drawing.Point(194, 150);
            txtFilename1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFilename1.Name = "txtFilename1";
            txtFilename1.Size = new System.Drawing.Size(140, 23);
            txtFilename1.TabIndex = 9;
            // 
            // lbFilename1
            // 
            lbFilename1.AutoSize = true;
            lbFilename1.Location = new System.Drawing.Point(62, 153);
            lbFilename1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbFilename1.Name = "lbFilename1";
            lbFilename1.Size = new System.Drawing.Size(123, 15);
            lbFilename1.TabIndex = 8;
            lbFilename1.Text = "Program #1 Filename:";
            // 
            // txtFilename2
            // 
            txtFilename2.Location = new System.Drawing.Point(194, 185);
            txtFilename2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFilename2.Name = "txtFilename2";
            txtFilename2.Size = new System.Drawing.Size(140, 23);
            txtFilename2.TabIndex = 11;
            // 
            // lbFilename2
            // 
            lbFilename2.AutoSize = true;
            lbFilename2.Location = new System.Drawing.Point(63, 188);
            lbFilename2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbFilename2.Name = "lbFilename2";
            lbFilename2.Size = new System.Drawing.Size(123, 15);
            lbFilename2.TabIndex = 10;
            lbFilename2.Text = "Program #2 Filename:";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(414, 264);
            Controls.Add(txtFilename2);
            Controls.Add(lbFilename2);
            Controls.Add(txtFilename1);
            Controls.Add(lbFilename1);
            Controls.Add(txtPort);
            Controls.Add(txtSecretCode);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(cbxTrayCommand);
            Controls.Add(lbPort);
            Controls.Add(lbSecretCode);
            Controls.Add(lbDefaultCommand);
            Controls.Add(chkAutoLoad);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "SettingsForm";
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.TextBox txtFilename1;
        private System.Windows.Forms.Label lbFilename1;
        private System.Windows.Forms.TextBox txtFilename2;
        private System.Windows.Forms.Label lbFilename2;
    }
}