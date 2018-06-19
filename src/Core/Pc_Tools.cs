using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Win32;
using System.Security;
using System.Diagnostics;
using NetworkMonitor;

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
        private void btnClearCOM_Click(object sender, EventArgs e) 
        {   
           const string keyLoc = @"SYSTEM\CurrentControlSet\Control\COM Name Arbiter";
            try 
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(keyLoc, true)) 
                {
                    //If key opening fails the object returns null
                    if (key == null) 
                    {
                        MessageBox.Show("Key not found!");
                        return;
                    }
                    //Write value to the registry;
                    key.SetValue("ComDB", "0", RegistryValueKind.String);
                    //MessageBox.Show("COM Ports clear!");
                    return;
                }
            } 
            catch (SecurityException ex)
            {
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


        private void btnHP800_Click(object sender, EventArgs e) 
        {
            Process.Start(@"Install\hp800Bios.exe");
        }

        private void btnSecEss_Click(object sender, EventArgs e) 
        {
            Process.Start(@"Install\mseinstall.exe");
        }


        private void btnLaunchRVI_Click(object sender, EventArgs e) 
        {
            Process.Start(@"Install\RandomVolumeID.exe");
        }


        private void btnSP3_Click(object sender, EventArgs e) 
        {
            Process.Start(@"Install\WindowsXP-KB936929-SP3-x86-ENU.exe");
        }

        private void btnClearPorts_Click(object sender, EventArgs e) 
        {
            btnClearCOM_Click(sender, e);
            MessageBox.Show("Ghost ports clear!");
        }

        private void btnNetMonitor_Click(object sender, EventArgs e) 
        {
            Program.runNewWindow(new NetworkMonitor.frmNetworkMonitor());
        }
    }
}
