namespace Toolkit {
    partial class frmAlignment {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlignment));
            this.picPro42 = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnPro42Install = new System.Windows.Forms.Button();
            this.btnPro42LanguagePatch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPro42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picPro42
            // 
            this.picPro42.Image = global::Toolkit.Properties.Resources.toolbox;
            this.picPro42.Location = new System.Drawing.Point(131, 71);
            this.picPro42.Name = "picPro42";
            this.picPro42.Size = new System.Drawing.Size(195, 246);
            this.picPro42.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPro42.TabIndex = 0;
            this.picPro42.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Toolkit.Properties.Resources.logo;
            this.picLogo.ImageLocation = "";
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(195, 40);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // btnPro42Install
            // 
            this.btnPro42Install.Location = new System.Drawing.Point(12, 71);
            this.btnPro42Install.Name = "btnPro42Install";
            this.btnPro42Install.Size = new System.Drawing.Size(112, 64);
            this.btnPro42Install.TabIndex = 9;
            this.btnPro42Install.Text = "Pro42 Install";
            this.btnPro42Install.UseVisualStyleBackColor = true;
            this.btnPro42Install.Click += new System.EventHandler(this.btnPro42Install_Click);
            // 
            // btnPro42LanguagePatch
            // 
            this.btnPro42LanguagePatch.Location = new System.Drawing.Point(334, 71);
            this.btnPro42LanguagePatch.Name = "btnPro42LanguagePatch";
            this.btnPro42LanguagePatch.Size = new System.Drawing.Size(112, 64);
            this.btnPro42LanguagePatch.TabIndex = 10;
            this.btnPro42LanguagePatch.Text = "Pro42 7.5 Language Patch";
            this.btnPro42LanguagePatch.UseVisualStyleBackColor = true;
            this.btnPro42LanguagePatch.Click += new System.EventHandler(this.btnPro42LanguagePatch_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(171, 333);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 64);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmAlignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 409);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPro42LanguagePatch);
            this.Controls.Add(this.btnPro42Install);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.picPro42);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlignment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alignment Menu";
            ((System.ComponentModel.ISupportInitialize)(this.picPro42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPro42;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnPro42Install;
        private System.Windows.Forms.Button btnPro42LanguagePatch;
        private System.Windows.Forms.Button btnBack;
    }
}