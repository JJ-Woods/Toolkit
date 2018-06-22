namespace CardWriter
{
    partial class frmCardWriter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCardWriter));
            this.lblCardUpdate = new System.Windows.Forms.Label();
            this.cmbCardOptions = new System.Windows.Forms.ComboBox();
            this.btnWriteCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCardUpdate
            // 
            this.lblCardUpdate.AutoSize = true;
            this.lblCardUpdate.Location = new System.Drawing.Point(22, 22);
            this.lblCardUpdate.Name = "lblCardUpdate";
            this.lblCardUpdate.Size = new System.Drawing.Size(67, 13);
            this.lblCardUpdate.TabIndex = 0;
            this.lblCardUpdate.Text = "Card Update";
            // 
            // cmbCardOptions
            // 
            this.cmbCardOptions.FormattingEnabled = true;
            this.cmbCardOptions.Location = new System.Drawing.Point(114, 22);
            this.cmbCardOptions.Name = "cmbCardOptions";
            this.cmbCardOptions.Size = new System.Drawing.Size(121, 21);
            this.cmbCardOptions.TabIndex = 1;
            // 
            // btnWriteCard
            // 
            this.btnWriteCard.Location = new System.Drawing.Point(265, 20);
            this.btnWriteCard.Name = "btnWriteCard";
            this.btnWriteCard.Size = new System.Drawing.Size(75, 23);
            this.btnWriteCard.TabIndex = 2;
            this.btnWriteCard.Text = "Write Card";
            this.btnWriteCard.UseVisualStyleBackColor = true;
            this.btnWriteCard.Click += new System.EventHandler(this.btnWriteCard_Click);
            // 
            // frmCardWriter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 71);
            this.Controls.Add(this.btnWriteCard);
            this.Controls.Add(this.cmbCardOptions);
            this.Controls.Add(this.lblCardUpdate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCardWriter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Card Writer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCardUpdate;
        private System.Windows.Forms.ComboBox cmbCardOptions;
        private System.Windows.Forms.Button btnWriteCard;
    }
}