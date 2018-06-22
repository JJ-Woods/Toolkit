using System;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

/**********************************************\
 *ENGINEER TOOLKIT                             *
 *Version: 2.0.0                               *
 *Written for: Snap-On Diagnostics             *
 *Written by: Jamie Woods                      *
 *On: 13/09/2014                               *
 \*********************************************/


namespace Toolkit 
{

    public partial class frmMainWindow : Form 
    {

        public frmMainWindow() 
        {
            InitializeComponent();
        }        


        //Send the user to snapon intranet login
        private void picLogo_Click(object sender, EventArgs e)
        {
            Process.Start("www.snapondiagnostics.co.uk");
        }


        //Open the about form
        private void picAbout_Click(object sender, EventArgs e) 
        {
            Program.runNewWindow(new frmAbout());
        }


        //Button simple sdp operations pressed, open simpOps form
        private void btnSimpleOps_Click(object sender, EventArgs e)
        {
            Program.openNewMenu(new frmEmission(), this, "emisionsMenu");
        }

        
        //Open allignment sub-menu
        private void btnAlligMenu_Click(object sender, EventArgs e) 
        {
            Program.openNewMenu(new frmAlignment(), this, "pro42Menu");
        }


        //Open brake test sub-menu
        private void btnBreakTestMenu_Click(object sender, EventArgs e)
        {
            Program.openNewMenu(new frmBrakeTest(), this, "BrakeTestMenu");
        }


        //Open the balance sub-menu
        private void btnBalanceMenu_Click(object sender, EventArgs e)
        {
            Program.openNewMenu(new frmBalance(), this, "balanceMenu");
        }


        //Open the pc tool sub-menu
        private void btnPCToolsMenu_Click(object sender, EventArgs e) 
        {
            Program.openNewMenu(new frmPCTools(), this, "pcToolsMenu");
        }
    }
}
