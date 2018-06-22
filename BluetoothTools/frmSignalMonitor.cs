using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BluetoothTools {
    public partial class frmSignalMonitor : Form {
        public frmSignalMonitor() {
            InitializeComponent();
        }

        private void btnGetPorts_Click(object sender, EventArgs e) {

            lsbDevices.Items.Clear();

            BluetoothInterface.InterfaceControl btObj = new BluetoothInterface.InterfaceControl();
            BluetoothInterface.Device [] devices = btObj.scanDevices().ToArray();

            if (devices.Length == 0) {
                lsbDevices.Items.Add("No devices avalible!");
                return;
            }

            foreach (BluetoothInterface.Device device in devices) {
                lsbDevices.Items.Add(device);
            }
        }
    }
}
