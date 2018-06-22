using System;
using System.Collections.Generic;
using System.Windows.Forms;

/**********************************************\
 *SDP UPDATER                                  *
 *Version: 1.0.0                               *
 *Written for: Snap-On Diagnostics             *
 *Written by: Jamie Woods                      *
 *On: 08/04/2014                               *
 \*********************************************/

namespace SDP_Update {

    public partial class frmSDP_Update : Form {

        SDPUControl control = new SDPUControl();


        public frmSDP_Update() {

            InitializeComponent();

            string[] avalibleUpdates = control.getUpdates();
            foreach (string update in avalibleUpdates) {
                cmbVersion.Items.Add(update);
            }
        }


        //Set the selected version
        private void cmbVersion_SelectedIndexChanged(object sender, EventArgs e) {

            if (cmbVersion.SelectedItem != null) {

                control.versionPub = cmbVersion.SelectedItem.ToString();
            }
        }


        //Update button pressed, run the SDP update
        private void btnUpdate_Click(object sender, EventArgs e) {

            try {

                control.copyUpdate();
                MessageBox.Show("Update Complete");

            } catch (Exception ex){

                MessageBox.Show("Update Failed\n" + ex.Message);
            }
        }
    }
}
