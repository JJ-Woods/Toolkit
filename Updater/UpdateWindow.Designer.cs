namespace Updater {
    partial class frmUpdateWindow {
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
            this.lblInstall = new System.Windows.Forms.Label();
            this.lsbInstall = new System.Windows.Forms.ListBox();
            this.btnNewInstall = new System.Windows.Forms.Button();
            this.lsbSourceDir = new System.Windows.Forms.ListBox();
            this.lsbSourceFiles = new System.Windows.Forms.ListBox();
            this.btnNewSourceDir = new System.Windows.Forms.Button();
            this.btnNewSourceFile = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRemoveInstall = new System.Windows.Forms.Button();
            this.btnRemoveDIR = new System.Windows.Forms.Button();
            this.btnRemoveFile = new System.Windows.Forms.Button();
            this.lblSourceFolders = new System.Windows.Forms.Label();
            this.lblSourceFiles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInstall
            // 
            this.lblInstall.AutoSize = true;
            this.lblInstall.Location = new System.Drawing.Point(13, 13);
            this.lblInstall.Name = "lblInstall";
            this.lblInstall.Size = new System.Drawing.Size(61, 13);
            this.lblInstall.TabIndex = 0;
            this.lblInstall.Text = "Install Files:";
            // 
            // lsbInstall
            // 
            this.lsbInstall.FormattingEnabled = true;
            this.lsbInstall.Location = new System.Drawing.Point(16, 33);
            this.lsbInstall.Name = "lsbInstall";
            this.lsbInstall.Size = new System.Drawing.Size(152, 69);
            this.lsbInstall.TabIndex = 1;
            // 
            // btnNewInstall
            // 
            this.btnNewInstall.Location = new System.Drawing.Point(12, 108);
            this.btnNewInstall.Name = "btnNewInstall";
            this.btnNewInstall.Size = new System.Drawing.Size(75, 52);
            this.btnNewInstall.TabIndex = 2;
            this.btnNewInstall.Text = "New Install Location";
            this.btnNewInstall.UseVisualStyleBackColor = true;
            // 
            // lsbSourceDir
            // 
            this.lsbSourceDir.FormattingEnabled = true;
            this.lsbSourceDir.Location = new System.Drawing.Point(191, 33);
            this.lsbSourceDir.Name = "lsbSourceDir";
            this.lsbSourceDir.Size = new System.Drawing.Size(156, 69);
            this.lsbSourceDir.TabIndex = 3;
            this.lsbSourceDir.SelectedIndexChanged += new System.EventHandler(this.lsbSourceDir_SelectedIndexChanged);
            // 
            // lsbSourceFiles
            // 
            this.lsbSourceFiles.FormattingEnabled = true;
            this.lsbSourceFiles.Location = new System.Drawing.Point(366, 33);
            this.lsbSourceFiles.Name = "lsbSourceFiles";
            this.lsbSourceFiles.Size = new System.Drawing.Size(155, 69);
            this.lsbSourceFiles.TabIndex = 4;
            // 
            // btnNewSourceDir
            // 
            this.btnNewSourceDir.Location = new System.Drawing.Point(191, 108);
            this.btnNewSourceDir.Name = "btnNewSourceDir";
            this.btnNewSourceDir.Size = new System.Drawing.Size(75, 52);
            this.btnNewSourceDir.TabIndex = 5;
            this.btnNewSourceDir.Text = "New Source Directory";
            this.btnNewSourceDir.UseVisualStyleBackColor = true;
            // 
            // btnNewSourceFile
            // 
            this.btnNewSourceFile.Location = new System.Drawing.Point(366, 108);
            this.btnNewSourceFile.Name = "btnNewSourceFile";
            this.btnNewSourceFile.Size = new System.Drawing.Size(75, 52);
            this.btnNewSourceFile.TabIndex = 6;
            this.btnNewSourceFile.Text = "New Source File";
            this.btnNewSourceFile.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(231, 167);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 25);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRemoveInstall
            // 
            this.btnRemoveInstall.Location = new System.Drawing.Point(93, 108);
            this.btnRemoveInstall.Name = "btnRemoveInstall";
            this.btnRemoveInstall.Size = new System.Drawing.Size(75, 52);
            this.btnRemoveInstall.TabIndex = 8;
            this.btnRemoveInstall.Text = "Remove Install Location";
            this.btnRemoveInstall.UseVisualStyleBackColor = true;
            // 
            // btnRemoveDIR
            // 
            this.btnRemoveDIR.Location = new System.Drawing.Point(272, 108);
            this.btnRemoveDIR.Name = "btnRemoveDIR";
            this.btnRemoveDIR.Size = new System.Drawing.Size(75, 52);
            this.btnRemoveDIR.TabIndex = 9;
            this.btnRemoveDIR.Text = "Remove Source Directory";
            this.btnRemoveDIR.UseVisualStyleBackColor = true;
            // 
            // btnRemoveFile
            // 
            this.btnRemoveFile.Location = new System.Drawing.Point(447, 108);
            this.btnRemoveFile.Name = "btnRemoveFile";
            this.btnRemoveFile.Size = new System.Drawing.Size(75, 52);
            this.btnRemoveFile.TabIndex = 10;
            this.btnRemoveFile.Text = "Remove Source File";
            this.btnRemoveFile.UseVisualStyleBackColor = true;
            // 
            // lblSourceFolders
            // 
            this.lblSourceFolders.AutoSize = true;
            this.lblSourceFolders.Location = new System.Drawing.Point(191, 14);
            this.lblSourceFolders.Name = "lblSourceFolders";
            this.lblSourceFolders.Size = new System.Drawing.Size(81, 13);
            this.lblSourceFolders.TabIndex = 11;
            this.lblSourceFolders.Text = "Source Folders:";
            // 
            // lblSourceFiles
            // 
            this.lblSourceFiles.AutoSize = true;
            this.lblSourceFiles.Location = new System.Drawing.Point(366, 14);
            this.lblSourceFiles.Name = "lblSourceFiles";
            this.lblSourceFiles.Size = new System.Drawing.Size(68, 13);
            this.lblSourceFiles.TabIndex = 12;
            this.lblSourceFiles.Text = "Source Files:";
            // 
            // frmUpdateWindow
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 204);
            this.Controls.Add(this.lblSourceFiles);
            this.Controls.Add(this.lblSourceFolders);
            this.Controls.Add(this.btnRemoveFile);
            this.Controls.Add(this.btnRemoveDIR);
            this.Controls.Add(this.btnRemoveInstall);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNewSourceFile);
            this.Controls.Add(this.btnNewSourceDir);
            this.Controls.Add(this.lsbSourceFiles);
            this.Controls.Add(this.lsbSourceDir);
            this.Controls.Add(this.btnNewInstall);
            this.Controls.Add(this.lsbInstall);
            this.Controls.Add(this.lblInstall);
            this.Name = "frmUpdateWindow";
            this.Text = "Updater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstall;
        private System.Windows.Forms.ListBox lsbInstall;
        private System.Windows.Forms.Button btnNewInstall;
        private System.Windows.Forms.ListBox lsbSourceDir;
        private System.Windows.Forms.ListBox lsbSourceFiles;
        private System.Windows.Forms.Button btnNewSourceDir;
        private System.Windows.Forms.Button btnNewSourceFile;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemoveInstall;
        private System.Windows.Forms.Button btnRemoveDIR;
        private System.Windows.Forms.Button btnRemoveFile;
        private System.Windows.Forms.Label lblSourceFolders;
        private System.Windows.Forms.Label lblSourceFiles;
    }
}

