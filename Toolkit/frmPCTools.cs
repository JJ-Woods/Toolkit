using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Win32;
using System.Security;
using System.Diagnostics;

namespace Toolkit {

    public partial class frmPCTools : Form {

        public frmPCTools() {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e) 
        {

            Program.openNewMenu(new frmMainWindow(), this, "mainMenu");    
        }

        //Clear all the saved com ports in windows
        private void btnClearCOM_Click(object sender, EventArgs e) {
           
           const string keyLoc = @"SYSTEM\CurrentControlSet\Control\COM Name Arbiter";

            try {

                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(keyLoc, true)) {

                    //If key opening fails the object returns null
                    if (key == null) {
                        MessageBox.Show("Key not found!");
                        return;
                    }

                    //Write value to the registry;
                    key.SetValue("ComDB", "0", RegistryValueKind.String);

                    MessageBox.Show("COM Ports clear!");
                    return;
                }
            } catch (SecurityException ex){

                MessageBox.Show("Error!\nTry running as Admin!");
            }
        }


        private void btnToshErrorFix_Click(object sender, EventArgs e) {

            const string keyLoc = @"Software\Toshiba\BluetoothStack\V1.0\Mng";

            try {
             
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(keyLoc, true)) {

                    //If key opening fails the object returns null
                    if (key == null) {
                        MessageBox.Show("Key not found!");
                        return;
                    }

                    //Write value to the registry;
                    key.SetValue("TestVersion", "1", RegistryValueKind.DWord);

                    MessageBox.Show("Licence updated!");
                    return;
                }
            } catch (SecurityException ex) {

                MessageBox.Show("Error!\nTry running as Admin!");
            }
        }


        //Update the version of .NET
        private void btnUpdateDotNet_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"Install\dotNetUpdate.exe");
            }
            catch(System.ComponentModel.Win32Exception)
            {
                //MessageBox.Show("Install error!");
            }
        }
    }
}
