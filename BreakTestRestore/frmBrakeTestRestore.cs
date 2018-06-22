using System;
using System.Collections.Generic;
using System.Windows.Forms;

/**********************************************\
 *BRAKE TEST RESTORER                          *
 *Version: 1.0.0                               *
 *Written for: Snap-On Diagnostics             *
 *Written by: Jamie Woods                      *
 *On: 08/04/2014                               *
 \*********************************************/

namespace BrakeTestRestore {

    public partial class frmBrakeTestRestore : Form {

        //Object of the control class
        BTRControl controlObject = new BTRControl();

        public frmBrakeTestRestore() {

            InitializeComponent();

            //Get and display each avalible operating system
            List<string> systems = controlObject.getSystems();
            foreach (string sys in systems) {
                cmbOpSys.Items.Add(sys);
            }

            //Get and display each avalible unit
            List<string> units = controlObject.getUnits();
            foreach (string unit in units) {
                cmbMachine.Items.Add(unit);
            }
        }


        //Set up button pressed, do setup
        private void btnSetup_Click_1(object sender, EventArgs e) {

            //Check each required field has been filled in
            if (!runChecks()) {
                return;
            }

            //Run the setup (inside control class)
            string errorMessage;
            if (!controlObject.doSetup(cmbMachine.SelectedItem.ToString(), out errorMessage)) {
                MessageBox.Show(errorMessage);
                return;
            }

            MessageBox.Show("Set up complete!");
        }

        //Check required fields have been filled in
        private bool runChecks() {

            //Check an operating system has been selected
            if (cmbOpSys.SelectedItem == null) {
                MessageBox.Show("Please select an operating system");
                return false;
            }

            //Check a machine has been selected
            if (cmbMachine.SelectedItem == null) {
                MessageBox.Show("Please select a machine");
                return false;
            }

            return true;
        }


        //Button remove clicked, run clean up
        private void btnRemove_Click_1(object sender, EventArgs e) {

            //Check the operating system has been selected
            if (cmbOpSys.SelectedItem == null) {
                MessageBox.Show("Please select an operating system");
                return;
            }

            //Run the clean up (inside control class)
            controlObject.cleanUp();

            MessageBox.Show("Clean up complete!");
        }


        //Selected operating system changed
        private void cmbOpSys_SelectedIndexChanged_1(object sender, EventArgs e) {

            //Selected the winXP path
            if (cmbOpSys.SelectedItem.ToString() == "Windows XP") {
                controlObject.setSystem(@"C:\Documents and Settings\All Users\Start Menu\Programs\Startup\");
            }

            //Select the win7 path
            else if (cmbOpSys.SelectedItem.ToString() == "Windows 7") {
                controlObject.setSystem(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Startup\");
            }

            //This case should not occur, just a double check clause
            else {
                MessageBox.Show("Operating System Error");
                return;
            }
            cmbMachine.Enabled = true;
        }


        //Selected machine changed
        private void cmbMachine_SelectedIndexChanged_1(object sender, EventArgs e) {

            string machine = cmbMachine.SelectedItem.ToString();

            //John bean folder has unusual name
            if (machine == "John Bean") {
                machine = "bde40w4";
            }

            //Set the selected machine in the control class
            controlObject.setUnit(cmbMachine.SelectedItem.ToString());
        }
    }
    
}