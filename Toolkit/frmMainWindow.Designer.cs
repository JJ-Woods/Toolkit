namespace Toolkit {
    partial class frmMainWindow {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainWindow));
            this.btnBreakTestMenu = new System.Windows.Forms.Button();
            this.btnEmmisionsWindow = new System.Windows.Forms.Button();
            this.btnPCToolsMenu = new System.Windows.Forms.Button();
            this.btnAlligMenu = new System.Windows.Forms.Button();
            this.btnBalanceMenu = new System.Windows.Forms.Button();
            this.picAbout = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBreakTestMenu
            // 
            this.btnBreakTestMenu.Location = new System.Drawing.Point(12, 253);
            this.btnBreakTestMenu.Name = "btnBreakTestMenu";
            this.btnBreakTestMenu.Size = new System.Drawing.Size(112, 64);
            this.btnBreakTestMenu.TabIndex = 2;
            this.btnBreakTestMenu.Text = "Brake Test";
            this.btnBreakTestMenu.UseVisualStyleBackColor = true;
            this.btnBreakTestMenu.Click += new System.EventHandler(this.btnBreakTestMenu_Click);
            // 
            // btnEmmisionsWindow
            // 
            this.btnEmmisionsWindow.Location = new System.Drawing.Point(12, 71);
            this.btnEmmisionsWindow.Name = "btnEmmisionsWindow";
            this.btnEmmisionsWindow.Size = new System.Drawing.Size(112, 64);
            this.btnEmmisionsWindow.TabIndex = 0;
            this.btnEmmisionsWindow.Text = "Emissions";
            this.btnEmmisionsWindow.UseVisualStyleBackColor = true;
            this.btnEmmisionsWindow.Click += new System.EventHandler(this.btnSimpleOps_Click);
            // 
            // btnPCToolsMenu
            // 
            this.btnPCToolsMenu.Location = new System.Drawing.Point(334, 164);
            this.btnPCToolsMenu.Name = "btnPCToolsMenu";
            this.btnPCToolsMenu.Size = new System.Drawing.Size(112, 64);
            this.btnPCToolsMenu.TabIndex = 7;
            this.btnPCToolsMenu.Text = "PC Tools";
            this.btnPCToolsMenu.UseVisualStyleBackColor = true;
            this.btnPCToolsMenu.Click += new System.EventHandler(this.btnPCToolsMenu_Click);
            // 
            // btnAlligMenu
            // 
            this.btnAlligMenu.Location = new System.Drawing.Point(13, 164);
            this.btnAlligMenu.Name = "btnAlligMenu";
            this.btnAlligMenu.Size = new System.Drawing.Size(112, 64);
            this.btnAlligMenu.TabIndex = 8;
            this.btnAlligMenu.Text = "Alignment";
            this.btnAlligMenu.UseVisualStyleBackColor = true;
            this.btnAlligMenu.Click += new System.EventHandler(this.btnAlligMenu_Click);
            // 
            // btnBalanceMenu
            // 
            this.btnBalanceMenu.Location = new System.Drawing.Point(334, 71);
            this.btnBalanceMenu.Name = "btnBalanceMenu";
            this.btnBalanceMenu.Size = new System.Drawing.Size(112, 64);
            this.btnBalanceMenu.TabIndex = 9;
            this.btnBalanceMenu.Text = "Balance";
            this.btnBalanceMenu.UseVisualStyleBackColor = true;
            this.btnBalanceMenu.Click += new System.EventHandler(this.btnBalanceMenu_Click);
            // 
            // picAbout
            // 
            this.picAbout.Image = global::Toolkit.Properties.Resources.about_icon;
            this.picAbout.Location = new System.Drawing.Point(419, 12);
            this.picAbout.Name = "picAbout";
            this.picAbout.Size = new System.Drawing.Size(27, 24);
            this.picAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAbout.TabIndex = 6;
            this.picAbout.TabStop = false;
            this.picAbout.Click += new System.EventHandler(this.picAbout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Toolkit.Properties.Resources.toolbox;
            this.pictureBox1.Location = new System.Drawing.Point(131, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 246);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // picLogo
            // 
            this.picLogo.Image = global::Toolkit.Properties.Resources.logo;
            this.picLogo.ImageLocation = "";
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(195, 40);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 2;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 329);
            this.Controls.Add(this.btnBalanceMenu);
            this.Controls.Add(this.btnAlligMenu);
            this.Controls.Add(this.btnPCToolsMenu);
            this.Controls.Add(this.picAbout);
            this.Controls.Add(this.btnEmmisionsWindow);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnBreakTestMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Engineer Toolkit";
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBreakTestMenu;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEmmisionsWindow;
        private System.Windows.Forms.PictureBox picAbout;
        private System.Windows.Forms.Button btnPCToolsMenu;
        private System.Windows.Forms.Button btnAlligMenu;
        private System.Windows.Forms.Button btnBalanceMenu;
    }
}

