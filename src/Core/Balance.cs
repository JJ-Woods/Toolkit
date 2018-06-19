using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;

namespace Toolkit
{

    public partial class frmBalance : Form 
    {

        public frmBalance() 
        {
            InitializeComponent();
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.openNewMenu(new frmMainWindow(), this, "mainMenu");
        }



        private void btnCreateSDCard_Click(object sender, EventArgs e)
        {
            Program.runNewWindow(new CardWriter.frmCardWriter());
        }
    }
}
