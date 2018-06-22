namespace BluetoothTools {
    partial class frmBluetoothTools {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBluetoothTools));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picBTSymbol = new System.Windows.Forms.PictureBox();
            this.btnInstallLogger = new System.Windows.Forms.Button();
            this.btnSignalMeter = new System.Windows.Forms.Button();
            this.btnClearCOM = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTSymbol)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = global::BluetoothTools.Properties.Resources.logo;
            this.picLogo.ImageLocation = "";
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(195, 40);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // picBTSymbol
            // 
            this.picBTSymbol.Image = global::BluetoothTools.Properties.Resources.btSymbol;
            this.picBTSymbol.Location = new System.Drawing.Point(131, 71);
            this.picBTSymbol.Name = "picBTSymbol";
            this.picBTSymbol.Size = new System.Drawing.Size(195, 246);
            this.picBTSymbol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBTSymbol.TabIndex = 0;
            this.picBTSymbol.TabStop = false;
            // 
            // btnInstallLogger
            // 
            this.btnInstallLogger.Location = new System.Drawing.Point(13, 160);
            this.btnInstallLogger.Name = "btnInstallLogger";
            this.btnInstallLogger.Size = new System.Drawing.Size(112, 64);
            this.btnInstallLogger.TabIndex = 1;
            this.btnInstallLogger.Text = "Install Logger";
            this.btnInstallLogger.UseVisualStyleBackColor = true;
            this.btnInstallLogger.Click += new System.EventHandler(this.btnInstallLogger_Click);
            // 
            // btnSignalMeter
            // 
            this.btnSignalMeter.Location = new System.Drawing.Point(12, 71);
            this.btnSignalMeter.Name = "btnSignalMeter";
            this.btnSignalMeter.Size = new System.Drawing.Size(112, 64);
            this.btnSignalMeter.TabIndex = 0;
            this.btnSignalMeter.Text = "Signal Meter";
            this.btnSignalMeter.UseVisualStyleBackColor = true;
            this.btnSignalMeter.Click += new System.EventHandler(this.btnSignalMeter_Click);
            // 
            // btnClearCOM
            // 
            this.btnClearCOM.Location = new System.Drawing.Point(12, 253);
            this.btnClearCOM.Name = "btnClearCOM";
            this.btnClearCOM.Size = new System.Drawing.Size(112, 64);
            this.btnClearCOM.TabIndex = 2;
            this.btnClearCOM.Text = "Clear COM Ports";
            this.btnClearCOM.UseVisualStyleBackColor = true;
            this.btnClearCOM.Click += new System.EventHandler(this.btnClearCOM_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(332, 253);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 64);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmBluetoothTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 329);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClearCOM);
            this.Controls.Add(this.btnSignalMeter);
            this.Controls.Add(this.btnInstallLogger);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.picBTSymbol);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmBluetoothTools";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bluetooth Tools";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBTSymbol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBTSymbol;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnInstallLogger;
        private System.Windows.Forms.Button btnSignalMeter;
        private System.Windows.Forms.Button btnClearCOM;
        private System.Windows.Forms.Button btnBack;
    }
}