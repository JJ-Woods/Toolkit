using System;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;


/**********************************************\
 *TOOLKIT EMISSION MENU                        *
 *Version: 1.0.0                               *
 *Written for: Snap-On Diagnostics             *
 *Written by: Jamie Woods                      *
 *On: 13/09/2014                               *
 \*********************************************/


namespace Toolkit
{

    public partial class frmEmission : Form 
    {


        public frmEmission() 
        {

            InitializeComponent();

            //Check the versions of all the software
            getSDPVersion();
            getLimitsVersion();
        }


        //Check the version of specified file
        private void checkVersion(string filePath, Button btn) {
            string version;

            try
            {

                //Read the version number from the version file
                using (StreamReader reader = new StreamReader(filePath)) 
                {

                    version = reader.ReadLine();
                }

                //Amend the button to the current version number
                version = String.Format("\n({0})", version);
                btn.Text = btn.Text + version;

            }
                //If the version file does not exist disable the button and give an error
            catch (DirectoryNotFoundException e) 
            {

                btn.Text = "??VERSION??";
                btn.Enabled = false;
            }
        }


        //Grab the uninstall string from the registry key, parse it and execute to unistall selected program
        private void uninstallProgram(string keyLoc) 
        {

            //Access RegKey
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(keyLoc)) 
            {

                if (key == null) 
                {

                    MessageBox.Show("Key not found!");
                    return;
                }

                //Parse the key, first 8 letters are the process, remainder of string is parametors
                string uninstallString = key.GetValue("UninstallString").ToString();
                string filePath = uninstallString.Substring(0, 8) + ".exe";
                string parameters = uninstallString.Substring(8);

                //Execute the uninstall
                try 
                {

                    Process p = new Process();
                    p.StartInfo.FileName = filePath;
                    p.StartInfo.Arguments = parameters;
                    p.Start();
                } 
                catch
                {

                    MessageBox.Show("Uninstall failed!");
                }
            }
        }


        //Get the version of SDP in toolkit
        private void getSDPVersion() 
        {
            const string path = @"Install\SDP\Version.txt";

            checkVersion(path, btnInstall);
        }


        //Get the limits version
        private void getLimitsVersion()
        {

            const string path = @"Install\MOT_Limits\Version.txt";

            checkVersion(path, btnInstallLimits);            
        }


        //Run the SDP installer
        private void btnInstall_Click(object sender, EventArgs e)
        {

            Process.Start(@"Install\SDP\Setup.exe");
        }


        //Uninstalls SDP
        private void btnRemove_Click(object sender, EventArgs e)
        {

            const string keyLocation = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\{AFA9F499-8DC6-11D6-AB49-004854524A29}";

            uninstallProgram(keyLocation);
            
        }


        //Install MOT update patch
        private void btnInstallLimits_Click(object sender, EventArgs e)
        {

            Process.Start(@"Install\MOT_Limits\Setup.exe");
        }


        //Uninstall MOT update patch
        private void btnUninstallLimits_Click(object sender, EventArgs e) 
        {

            const string keyLocation = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\{7CA5C413-FEC7-4B13-B3AB-32479B0DE641}";

            uninstallProgram(keyLocation);
        }
        
        
        //Run the SDP updater (sub-component - SDP_Update)
        private void btnVersionUpdate_Click(object sender, EventArgs e) 
        {

            Program.runNewWindow(new SDP_Update.frmSDP_Update());
        }
        

        //Run the RegUpdater (button update) extention component
        private void btnRegUpdate_Click(object sender, EventArgs e) 
        {

            RegUpdater.frmRegUpdater regUpdateUI = new RegUpdater.frmRegUpdater();

            Program.runNewWindow(regUpdateUI);
        }

                    
        //Send the user back to the main menu
        private void btnBack_Click(object sender, EventArgs e) 
        {
            
            Program.openNewMenu(new frmMainWindow(), this, "mainMenu");
            
        }
    }  
}
