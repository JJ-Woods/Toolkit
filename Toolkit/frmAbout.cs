using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Toolkit {
    public partial class frmAbout : Form {

        public frmAbout() {

            InitializeComponent();
        }

        private void linkPracProg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {

            Process.Start("www.PracticalProgramming.co.uk");
        }
    }
}
