namespace Toolkit {
    partial class frmPCTools {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPCTools));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClearCOM = new System.Windows.Forms.Button();
            this.btnBluetoothTools = new System.Windows.Forms.Button();
            this.btnToshErrorFix = new System.Windows.Forms.Button();
            this.btnUpdateDotNet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Toolkit.Properties.Resources.logo;
            this.picLogo.ImageLocation = "";
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(195, 40);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 6;
            this.picLogo.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(169, 333);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 64);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Toolkit.Properties.Resources.toolbox;
            this.pictureBox1.Location = new System.Drawing.Point(128, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnClearCOM
            // 
            this.btnClearCOM.Location = new System.Drawing.Point(10, 159);
            this.btnClearCOM.Name = "btnClearCOM";
            this.btnClearCOM.Size = new System.Drawing.Size(112, 64);
            this.btnClearCOM.TabIndex = 9;
            this.btnClearCOM.Text = "Clear COM Ports";
            this.btnClearCOM.UseVisualStyleBackColor = true;
            this.btnClearCOM.Click += new System.EventHandler(this.btnClearCOM_Click);
            // 
            // btnBluetoothTools
            // 
            this.btnBluetoothTools.Enabled = false;
            this.btnBluetoothTools.Location = new System.Drawing.Point(332, 67);
            this.btnBluetoothTools.Name = "btnBluetoothTools";
            this.btnBluetoothTools.Size = new System.Drawing.Size(112, 64);
            this.btnBluetoothTools.TabIndex = 10;
            this.btnBluetoothTools.Text = "Bluetooth Tools";
            this.btnBluetoothTools.UseVisualStyleBackColor = true;
            // 
            // btnToshErrorFix
            // 
            this.btnToshErrorFix.Location = new System.Drawing.Point(10, 67);
            this.btnToshErrorFix.Name = "btnToshErrorFix";
            this.btnToshErrorFix.Size = new System.Drawing.Size(112, 64);
            this.btnToshErrorFix.TabIndex = 11;
            this.btnToshErrorFix.Text = "Toshiba Error Message";
            this.btnToshErrorFix.UseVisualStyleBackColor = true;
            this.btnToshErrorFix.Click += new System.EventHandler(this.btnToshErrorFix_Click);
            // 
            // btnUpdateDotNet
            // 
            this.btnUpdateDotNet.Location = new System.Drawing.Point(10, 249);
            this.btnUpdateDotNet.Name = "btnUpdateDotNet";
            this.btnUpdateDotNet.Size = new System.Drawing.Size(112, 64);
            this.btnUpdateDotNet.TabIndex = 12;
            this.btnUpdateDotNet.Text = "Update .NET";
            this.btnUpdateDotNet.UseVisualStyleBackColor = true;
            this.btnUpdateDotNet.Click += new System.EventHandler(this.btnUpdateDotNet_Click);
            // 
            // frmPCTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 409);
            this.Controls.Add(this.btnUpdateDotNet);
            this.Controls.Add(this.btnToshErrorFix);
            this.Controls.Add(this.btnBluetoothTools);
            this.Controls.Add(this.btnClearCOM);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPCTools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PC Tools";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClearCOM;
        private System.Windows.Forms.Button btnBluetoothTools;
        private System.Windows.Forms.Button btnToshErrorFix;
        private System.Windows.Forms.Button btnUpdateDotNet;
    }
}