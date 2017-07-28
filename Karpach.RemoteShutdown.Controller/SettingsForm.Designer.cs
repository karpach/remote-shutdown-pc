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
            this.SuspendLayout();
            // 
            // chkAutoLoad
            // 
            this.chkAutoLoad.AutoSize = true;
            this.chkAutoLoad.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkAutoLoad.Location = new System.Drawing.Point(12, 12);
            this.chkAutoLoad.Name = "chkAutoLoad";
            this.chkAutoLoad.Size = new System.Drawing.Size(165, 17);
            this.chkAutoLoad.TabIndex = 1;
            this.chkAutoLoad.Text = "Auto load at Windows startup";
            this.chkAutoLoad.UseVisualStyleBackColor = true;
            this.chkAutoLoad.CheckedChanged += new System.EventHandler(this.chkAutoLoad_CheckedChanged);
            // 
            // lbDefaultCommand
            // 
            this.lbDefaultCommand.AutoSize = true;
            this.lbDefaultCommand.Location = new System.Drawing.Point(13, 36);
            this.lbDefaultCommand.Name = "lbDefaultCommand";
            this.lbDefaultCommand.Size = new System.Drawing.Size(118, 13);
            this.lbDefaultCommand.TabIndex = 2;
            this.lbDefaultCommand.Text = "System Tray Command:";
            // 
            // cbxTrayCommand
            // 
            this.cbxTrayCommand.FormattingEnabled = true;
            this.cbxTrayCommand.Location = new System.Drawing.Point(138, 36);
            this.cbxTrayCommand.Name = "cbxTrayCommand";
            this.cbxTrayCommand.Size = new System.Drawing.Size(121, 21);
            this.cbxTrayCommand.TabIndex = 3;
            this.cbxTrayCommand.SelectedIndexChanged += new System.EventHandler(this.TrayCommandSelectedIndexChanged);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(55, 77);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(138, 77);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 129);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cbxTrayCommand);
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
    }
}