using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Toolkit {
    public partial class frmBrakeTest : Form {
        public frmBrakeTest() {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e) 
        {

            Program.openNewMenu(new frmMainWindow(), this, "mainMenu");
        }

        private void btnGermanErrorFix_Click(object sender, EventArgs e) 
        {
            BrakeTestRestore.frmBrakeTestRestore btrUI = new BrakeTestRestore.frmBrakeTestRestore();
            Program.runNewWindow(btrUI);
        }


        private void btnATLInstall_Click(object sender, EventArgs e)
        {
            Process.Start(@"Install\ATL2\setup.exe");
        }


        private void btnRPSoftware_Click(object sender, EventArgs e) 
        {
            Process.Start(@"Install\EESP931A\setup.exe");
        }
    }
}
