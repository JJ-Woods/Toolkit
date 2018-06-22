namespace RegUpdater {
    partial class frmRegUpdater {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegUpdater));
            this.lblOpSys = new System.Windows.Forms.Label();
            this.cmbOpSys = new System.Windows.Forms.ComboBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbLocations = new System.Windows.Forms.ComboBox();
            this.cmbPaths = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblOpSys
            // 
            this.lblOpSys.AutoSize = true;
            this.lblOpSys.Location = new System.Drawing.Point(286, 14);
            this.lblOpSys.Name = "lblOpSys";
            this.lblOpSys.Size = new System.Drawing.Size(93, 13);
            this.lblOpSys.TabIndex = 20;
            this.lblOpSys.Text = "Operating System:";
            // 
            // cmbOpSys
            // 
            this.cmbOpSys.Enabled = false;
            this.cmbOpSys.FormattingEnabled = true;
            this.cmbOpSys.Location = new System.Drawing.Point(289, 34);
            this.cmbOpSys.Name = "cmbOpSys";
            this.cmbOpSys.Size = new System.Drawing.Size(121, 21);
            this.cmbOpSys.TabIndex = 19;
            this.cmbOpSys.SelectedIndexChanged += new System.EventHandler(this.cmbOpSys_SelectedIndexChanged);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(150, 14);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(61, 13);
            this.lblPath.TabIndex = 18;
            this.lblPath.Text = "Update To:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(8, 15);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(86, 13);
            this.lblLocation.TabIndex = 17;
            this.lblLocation.Text = "Update shortcut:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(175, 77);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbLocations
            // 
            this.cmbLocations.FormattingEnabled = true;
            this.cmbLocations.Location = new System.Drawing.Point(8, 34);
            this.cmbLocations.Name = "cmbLocations";
            this.cmbLocations.Size = new System.Drawing.Size(121, 21);
            this.cmbLocations.TabIndex = 15;
            this.cmbLocations.SelectedIndexChanged += new System.EventHandler(this.cmbLocations_SelectedIndexChanged);
            // 
            // cmbPaths
            // 
            this.cmbPaths.Enabled = false;
            this.cmbPaths.FormattingEnabled = true;
            this.cmbPaths.Location = new System.Drawing.Point(150, 34);
            this.cmbPaths.Name = "cmbPaths";
            this.cmbPaths.Size = new System.Drawing.Size(121, 21);
            this.cmbPaths.TabIndex = 14;
            this.cmbPaths.SelectedIndexChanged += new System.EventHandler(this.cmbPaths_SelectedIndexChanged);
            // 
            // frmRegUpdater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 112);
            this.Controls.Add(this.lblOpSys);
            this.Controls.Add(this.cmbOpSys);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cmbLocations);
            this.Controls.Add(this.cmbPaths);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRegUpdater";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registry Updater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpSys;
        private System.Windows.Forms.ComboBox cmbOpSys;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbLocations;
        private System.Windows.Forms.ComboBox cmbPaths;
    }
}