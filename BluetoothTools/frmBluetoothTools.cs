using System;
using System.Windows.Forms;
using System.Threading;

namespace BluetoothTools {

    public partial class frmBluetoothTools : Form {


        BTToolsControl refObj = new BTToolsControl();


        public frmBluetoothTools() {
            InitializeComponent();
        }


        private void btnBack_Click(object sender, EventArgs e) {
            this.Close();
        }


        private void btnClearCOM_Click(object sender, EventArgs e) {
        }


        private void btnInstallLogger_Click(object sender, EventArgs e) {
            MessageBox.Show("STUB");
        }


        //Open the signal monitor window
        private void btnSignalMeter_Click(object sender, EventArgs e) {
            new frmSignalMonitor().ShowDialog();
        }
    }
}
