using System;
using System.Collections.Generic;
using System.Windows.Forms;

/**********************************************\
 *ENGINEER REGISTRY UPDATER                    *
 *Version: 1.0.0                               *
 *Written for: Snap-On Diagnostics             *
 *Written by: Jamie Woods                      *
 *On: 08/04/2014                               *
 \*********************************************/

namespace RegUpdater {

    public partial class frmRegUpdater : Form {

        //Object of the control class
        RUControl refObj = new RUControl();

        public frmRegUpdater() {

            InitializeComponent();

            //Read and display all program data
            List<string> locations = refObj.getData();
            foreach (string loc in locations) {
                cmbLocations.Items.Add(loc);
            }

            //Display the avalible operating systems
            List<string> opData = refObj.getOperatingSystems();
            foreach (string op in opData) {
                cmbOpSys.Items.Add(op);
            }
        }


        //On button press check values are correct and update registry
        private void btnUpdate_Click(object sender, EventArgs e) {

            //Check each field has a value
            if (cmbLocations.SelectedItem == null) {
                MessageBox.Show("Please select a location to update");
                return;
            }
            if (cmbPaths.SelectedItem == null) {
                MessageBox.Show("Please select a option to update");
                return;
            }
            if (cmbOpSys.SelectedItem == null) {
                MessageBox.Show("Please select an operating system");
                return;
            }
            string errorMessage;
            if (!refObj.updateReg(out errorMessage)) {
                MessageBox.Show(errorMessage);
                return;
            }
            MessageBox.Show("Setup Complete!");
        }


        //Set the selected location object and alter the dependant fields
        private void cmbLocations_SelectedIndexChanged(object sender, EventArgs e) {

            //Reset the form fields dependant on the location field
            cmbPaths.Enabled = true;
            cmbPaths.Items.Clear();
            cmbPaths.ResetText();
            cmbPaths.SelectedItem = null;
            cmbOpSys.ResetText();
            cmbOpSys.SelectedItem = null;

            string type = cmbLocations.SelectedItem.ToString();
            List<string> options = refObj.updateWindow(type);
            foreach (string opt in options) {
                cmbPaths.Items.Add(opt);
            }

            //Manipulate operating system box based on location
            switch (cmbLocations.SelectedItem.ToString()) {

                case "Brake Tester":
                    cmbOpSys.Enabled = true;
                    break;

                //Wheel alignment is windows 7 only
                case "Wheel Alignment":
                    cmbOpSys.Enabled = false;
                    cmbOpSys.Text = "Windows 7";
                    break;
            }
        }


        //Set the selected update to object
        private void cmbPaths_SelectedIndexChanged(object sender, EventArgs e) {
            //Select option with matching name
            string name = cmbPaths.SelectedItem.ToString();
            refObj.updateOption(name);
        }


        //Set the selected operating system object
        private void cmbOpSys_SelectedIndexChanged(object sender, EventArgs e) {
            if (cmbOpSys.SelectedItem != null) {
                refObj.updateOpSys(cmbOpSys.SelectedItem.ToString());
            }
        }
    }
}
