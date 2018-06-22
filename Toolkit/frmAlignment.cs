using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace Toolkit {

    public partial class frmAlignment : Form {

        public frmAlignment() {

            InitializeComponent();
            setPro42Version();
        }


        //Set the pro42 update version
        private void setPro42Version() {

            try {
                string version;

                using (StreamReader reader = new StreamReader(@"Install\Pro42\Version.txt")) {
                    version = reader.ReadLine();
                }

                version = String.Format("\n({0})", version);
                btnPro42Install.Text = btnPro42Install.Text + version;

            } catch (DirectoryNotFoundException e) {

                btnPro42Install.Text = "??VERSION??";
                btnPro42Install.Enabled = false;
            }
        }


        private void btnPro42Install_Click(object sender, EventArgs e) {
            Process p = new Process();
            p.StartInfo.FileName = @"Install\Pro42\Snapon\Setup.exe";
            p.Start();
        }


        //Button lang update pressed, run lan update code (no form)
        private void btnPro42LanguagePatch_Click(object sender, EventArgs e) {
            LanguageUpdater.LUControl luObject = new LanguageUpdater.LUControl();
            luObject.doUpdate();
            MessageBox.Show("Update complete!");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            Program.openNewMenu(new frmMainWindow(), this, "mainMenu");    
        }
    }
}
