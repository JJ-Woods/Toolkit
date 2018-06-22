namespace Toolkit {
    partial class frmAbout {
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
            this.lblRevTag = new System.Windows.Forms.Label();
            this.lblCompanyTag = new System.Windows.Forms.Label();
            this.lblProduced = new System.Windows.Forms.Label();
            this.lblRevision = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRevTag
            // 
            this.lblRevTag.AutoSize = true;
            this.lblRevTag.Location = new System.Drawing.Point(33, 18);
            this.lblRevTag.Name = "lblRevTag";
            this.lblRevTag.Size = new System.Drawing.Size(54, 13);
            this.lblRevTag.TabIndex = 0;
            this.lblRevTag.Text = "Revision: ";
            // 
            // lblCompanyTag
            // 
            this.lblCompanyTag.AutoSize = true;
            this.lblCompanyTag.Location = new System.Drawing.Point(16, 50);
            this.lblCompanyTag.Name = "lblCompanyTag";
            this.lblCompanyTag.Size = new System.Drawing.Size(71, 13);
            this.lblCompanyTag.TabIndex = 1;
            this.lblCompanyTag.Text = "Produced By:";
            // 
            // lblProduced
            // 
            this.lblProduced.AutoSize = true;
            this.lblProduced.Location = new System.Drawing.Point(111, 50);
            this.lblProduced.Name = "lblProduced";
            this.lblProduced.Size = new System.Drawing.Size(71, 13);
            this.lblProduced.TabIndex = 4;
            this.lblProduced.Text = "Jamie Woods";
            // 
            // lblRevision
            // 
            this.lblRevision.AutoSize = true;
            this.lblRevision.Location = new System.Drawing.Point(111, 18);
            this.lblRevision.Name = "lblRevision";
            this.lblRevision.Size = new System.Drawing.Size(31, 13);
            this.lblRevision.TabIndex = 5;
            this.lblRevision.Text = "2.1.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "If you have any ideas for tools to add to your";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Toolkit speak to Julian Woods";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 122);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRevision);
            this.Controls.Add(this.lblProduced);
            this.Controls.Add(this.lblCompanyTag);
            this.Controls.Add(this.lblRevTag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAbout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRevTag;
        private System.Windows.Forms.Label lblCompanyTag;
        private System.Windows.Forms.Label lblProduced;
        private System.Windows.Forms.Label lblRevision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}