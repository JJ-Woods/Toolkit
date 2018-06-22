namespace Toolkit {
    partial class frmEmission {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmission));
            this.btnVersionUpdate = new System.Windows.Forms.Button();
            this.btnInstall = new System.Windows.Forms.Button();
            this.btnUninstallSDP = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInstallLimits = new System.Windows.Forms.Button();
            this.btnUninstallLimits = new System.Windows.Forms.Button();
            this.btnRegUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVersionUpdate
            // 
            this.btnVersionUpdate.Location = new System.Drawing.Point(12, 246);
            this.btnVersionUpdate.Name = "btnVersionUpdate";
            this.btnVersionUpdate.Size = new System.Drawing.Size(112, 64);
            this.btnVersionUpdate.TabIndex = 2;
            this.btnVersionUpdate.Text = "Update SDP / Geogas";
            this.btnVersionUpdate.UseVisualStyleBackColor = true;
            this.btnVersionUpdate.Click += new System.EventHandler(this.btnVersionUpdate_Click);
            // 
            // btnInstall
            // 
            this.btnInstall.Location = new System.Drawing.Point(12, 64);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(112, 64);
            this.btnInstall.TabIndex = 0;
            this.btnInstall.Text = "Install SDP";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // btnUninstallSDP
            // 
            this.btnUninstallSDP.Location = new System.Drawing.Point(12, 154);
            this.btnUninstallSDP.Name = "btnUninstallSDP";
            this.btnUninstallSDP.Size = new System.Drawing.Size(112, 64);
            this.btnUninstallSDP.TabIndex = 1;
            this.btnUninstallSDP.Text = "Uninstall SDP";
            this.btnUninstallSDP.UseVisualStyleBackColor = true;
            this.btnUninstallSDP.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(169, 328);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 64);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Toolkit.Properties.Resources.logo;
            this.picLogo.ImageLocation = "";
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(195, 40);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 5;
            this.picLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Toolkit.Properties.Resources.toolbox;
            this.pictureBox1.Location = new System.Drawing.Point(130, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnInstallLimits
            // 
            this.btnInstallLimits.Location = new System.Drawing.Point(331, 64);
            this.btnInstallLimits.Name = "btnInstallLimits";
            this.btnInstallLimits.Size = new System.Drawing.Size(112, 64);
            this.btnInstallLimits.TabIndex = 3;
            this.btnInstallLimits.Text = "Install MOT Limits";
            this.btnInstallLimits.UseVisualStyleBackColor = true;
            this.btnInstallLimits.Click += new System.EventHandler(this.btnInstallLimits_Click);
            // 
            // btnUninstallLimits
            // 
            this.btnUninstallLimits.Location = new System.Drawing.Point(331, 154);
            this.btnUninstallLimits.Name = "btnUninstallLimits";
            this.btnUninstallLimits.Size = new System.Drawing.Size(112, 64);
            this.btnUninstallLimits.TabIndex = 4;
            this.btnUninstallLimits.Text = "Uninstall Limits";
            this.btnUninstallLimits.UseVisualStyleBackColor = true;
            this.btnUninstallLimits.Click += new System.EventHandler(this.btnUninstallLimits_Click);
            // 
            // btnRegUpdate
            // 
            this.btnRegUpdate.Location = new System.Drawing.Point(331, 246);
            this.btnRegUpdate.Name = "btnRegUpdate";
            this.btnRegUpdate.Size = new System.Drawing.Size(112, 64);
            this.btnRegUpdate.TabIndex = 7;
            this.btnRegUpdate.Text = "SDP Button Update";
            this.btnRegUpdate.UseVisualStyleBackColor = true;
            this.btnRegUpdate.Click += new System.EventHandler(this.btnRegUpdate_Click);
            // 
            // frmEmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 404);
            this.Controls.Add(this.btnRegUpdate);
            this.Controls.Add(this.btnUninstallLimits);
            this.Controls.Add(this.btnInstallLimits);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnUninstallSDP);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.btnVersionUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEmission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SDP Tools";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVersionUpdate;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Button btnUninstallSDP;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnInstallLimits;
        private System.Windows.Forms.Button btnUninstallLimits;
        private System.Windows.Forms.Button btnRegUpdate;
    }
}