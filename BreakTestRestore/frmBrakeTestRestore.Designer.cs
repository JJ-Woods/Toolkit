namespace BrakeTestRestore {
    partial class frmBrakeTestRestore {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBrakeTestRestore));
            this.cmbOpSys = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSetup = new System.Windows.Forms.Button();
            this.cmbMachine = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbOpSys
            // 
            this.cmbOpSys.FormattingEnabled = true;
            this.cmbOpSys.Location = new System.Drawing.Point(54, 18);
            this.cmbOpSys.Name = "cmbOpSys";
            this.cmbOpSys.Size = new System.Drawing.Size(121, 21);
            this.cmbOpSys.TabIndex = 11;
            this.cmbOpSys.Text = "Operating System...";
            this.cmbOpSys.SelectedIndexChanged += new System.EventHandler(this.cmbOpSys_SelectedIndexChanged_1);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(226, 64);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click_1);
            // 
            // btnSetup
            // 
            this.btnSetup.Location = new System.Drawing.Point(134, 64);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Size = new System.Drawing.Size(75, 23);
            this.btnSetup.TabIndex = 9;
            this.btnSetup.Text = "Setup";
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click_1);
            // 
            // cmbMachine
            // 
            this.cmbMachine.Enabled = false;
            this.cmbMachine.FormattingEnabled = true;
            this.cmbMachine.Location = new System.Drawing.Point(258, 18);
            this.cmbMachine.Name = "cmbMachine";
            this.cmbMachine.Size = new System.Drawing.Size(136, 21);
            this.cmbMachine.TabIndex = 8;
            this.cmbMachine.Text = "Select Machine...";
            this.cmbMachine.SelectedIndexChanged += new System.EventHandler(this.cmbMachine_SelectedIndexChanged_1);
            // 
            // frmBrakeTestRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 112);
            this.Controls.Add(this.cmbOpSys);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSetup);
            this.Controls.Add(this.cmbMachine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBrakeTestRestore";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brake Test Restore";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOpSys;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.ComboBox cmbMachine;

    }
}