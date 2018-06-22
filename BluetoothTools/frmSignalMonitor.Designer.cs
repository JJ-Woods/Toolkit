namespace BluetoothTools {
    partial class frmSignalMonitor {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.grpSource = new System.Windows.Forms.GroupBox();
            this.radSourceLog = new System.Windows.Forms.RadioButton();
            this.radSourceLive = new System.Windows.Forms.RadioButton();
            this.lblLog = new System.Windows.Forms.Label();
            this.lblLogActual = new System.Windows.Forms.Label();
            this.lsbDevices = new System.Windows.Forms.ListBox();
            this.btnGetPorts = new System.Windows.Forms.Button();
            this.grpSource.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSource
            // 
            this.grpSource.Controls.Add(this.radSourceLog);
            this.grpSource.Controls.Add(this.radSourceLive);
            this.grpSource.Location = new System.Drawing.Point(12, 12);
            this.grpSource.Name = "grpSource";
            this.grpSource.Size = new System.Drawing.Size(176, 45);
            this.grpSource.TabIndex = 0;
            this.grpSource.TabStop = false;
            this.grpSource.Text = "Source:";
            // 
            // radSourceLog
            // 
            this.radSourceLog.AutoSize = true;
            this.radSourceLog.Location = new System.Drawing.Point(101, 19);
            this.radSourceLog.Name = "radSourceLog";
            this.radSourceLog.Size = new System.Drawing.Size(43, 17);
            this.radSourceLog.TabIndex = 1;
            this.radSourceLog.TabStop = true;
            this.radSourceLog.Text = "Log";
            this.radSourceLog.UseVisualStyleBackColor = true;
            // 
            // radSourceLive
            // 
            this.radSourceLive.AutoSize = true;
            this.radSourceLive.Location = new System.Drawing.Point(7, 20);
            this.radSourceLive.Name = "radSourceLive";
            this.radSourceLive.Size = new System.Drawing.Size(45, 17);
            this.radSourceLive.TabIndex = 0;
            this.radSourceLive.TabStop = true;
            this.radSourceLive.Text = "Live";
            this.radSourceLive.UseVisualStyleBackColor = true;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(214, 32);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(31, 13);
            this.lblLog.TabIndex = 1;
            this.lblLog.Text = "Log: ";
            this.lblLog.Visible = false;
            // 
            // lblLogActual
            // 
            this.lblLogActual.AutoSize = true;
            this.lblLogActual.Location = new System.Drawing.Point(252, 32);
            this.lblLogActual.Name = "lblLogActual";
            this.lblLogActual.Size = new System.Drawing.Size(108, 13);
            this.lblLogActual.TabIndex = 2;
            this.lblLogActual.Text = "THIS IS STUB TEXT";
            this.lblLogActual.Visible = false;
            // 
            // lsbDevices
            // 
            this.lsbDevices.FormattingEnabled = true;
            this.lsbDevices.Location = new System.Drawing.Point(12, 76);
            this.lsbDevices.Name = "lsbDevices";
            this.lsbDevices.Size = new System.Drawing.Size(348, 95);
            this.lsbDevices.TabIndex = 3;
            // 
            // btnGetPorts
            // 
            this.btnGetPorts.Location = new System.Drawing.Point(12, 190);
            this.btnGetPorts.Name = "btnGetPorts";
            this.btnGetPorts.Size = new System.Drawing.Size(75, 23);
            this.btnGetPorts.TabIndex = 4;
            this.btnGetPorts.Text = "Get Ports";
            this.btnGetPorts.UseVisualStyleBackColor = true;
            this.btnGetPorts.Click += new System.EventHandler(this.btnGetPorts_Click);
            // 
            // frmSignalMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 251);
            this.Controls.Add(this.btnGetPorts);
            this.Controls.Add(this.lsbDevices);
            this.Controls.Add(this.lblLogActual);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.grpSource);
            this.Name = "frmSignalMonitor";
            this.Text = "Signal Monitor";
            this.grpSource.ResumeLayout(false);
            this.grpSource.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSource;
        private System.Windows.Forms.RadioButton radSourceLog;
        private System.Windows.Forms.RadioButton radSourceLive;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label lblLogActual;
        private System.Windows.Forms.ListBox lsbDevices;
        private System.Windows.Forms.Button btnGetPorts;
    }
}