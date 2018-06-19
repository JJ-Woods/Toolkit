using System;
using System.Collections.Generic;
using System.IO;

/**********************************************\
 *BRAKE TEST RESTORER                          *
 *Version: 1.0.0                               *
 *Written for: Snap-On Diagnostics             *
 *Written by: Jamie Woods                      *
 *On: 08/04/2014                               *
 \*********************************************/

namespace BrakeTestRestore{

    public class BTRControl{

        //Data for the class
        string[] units = {"Safelane", "John Bean", "Snapon-ATL", "VIC3000" };
        string[] opSys = {"Windows XP", "Windows 7" };

        //Selected items
        string selectedUnit;
        string selectedSystemPath;


        //Return a list of all avalible systems
        public List<string> getSystems() {
            
            List<string> systems = new List<string>();
            
            foreach (string sys in opSys) {
                systems.Add(sys);
            }

            return systems;
        }


        //Return a list of all avalible units
        public List<string> getUnits() {

            List<string> unitList = new List<string>();

            foreach (string unit in this.units) {
                unitList.Add(unit);
            }

            return unitList;
        }


        //Set the selected system
        public void setSystem(string sysPath) {

            this.selectedSystemPath = sysPath;
        }


        //Set the selected operating system
        public void setUnit(string unit) {
            
            this.selectedUnit = unit;
        }


        //Create hidden folder for logs, hidden back up folder and put restore script in start-up
        public bool doSetup(out string errorMessage)
        {
            string machinePath = String.Format(@"C:\{0}", this.selectedUnit);

            //Check the selected unit is installed on the machine
            if (!Directory.Exists(machinePath.ToUpper())) 
            {
                    errorMessage = "Machine not found!";
                    return false;
            }


            //Makes sure a comlog file is present (when first installed it isn't, breaks the script)
            string comLogPath = machinePath + "\\comunlog.txt";
            if (!File.Exists(comLogPath)) {
                File.Create(comLogPath);
            }

            //Make sure the user wants to delete current files
            if (
            (System.Windows.Forms.MessageBox.Show("Warning:\nProceding with this operation will delete all current files from the backup and log\n\nContinue?",
                                                  "WARNING",
                                                  System.Windows.Forms.MessageBoxButtons.YesNo,
                                                  System.Windows.Forms.MessageBoxIcon.Warning))
            ==
            System.Windows.Forms.DialogResult.No) {
                errorMessage = "Operation Aborted";
                return false;
            }

            //Create hidden folders for logfiles and backups
            string logfilePath = machinePath + @"\logfile";
            createHiddenDirectory(logfilePath);
            string backupPath = machinePath + @" backup";
            createHiddenDirectory(backupPath);

            try 
            {
                //Populate backup folder with entire contents of the installed folder
                new Microsoft.VisualBasic.Devices.Computer().FileSystem.CopyDirectory(machinePath, backupPath);
            } catch 
            {
                //Always seems to work second time for some reason, no idea why! 
                new Microsoft.VisualBasic.Devices.Computer().FileSystem.CopyDirectory(machinePath, backupPath);
            }
            string[] script = genScript(this.selectedUnit);
            string fileName = String.Format("{0}SOSU.vbs", this.selectedSystemPath);

            try {
                using (StreamWriter writer = new StreamWriter(fileName)) {
                    //Write the startup script into the startup folder
                    foreach (string value in script) {
                        writer.WriteLine(value);
                    }
                }
            
            //Exception thrown is trying to access startup when not admin
            } catch (UnauthorizedAccessException ex) {
                errorMessage = (ex.Message + "\n\nTry runnnig as admin");
                return false;
            }

            //No error message if the method completes successfully
            errorMessage = "";
            return true;
        }


        //Create a hidden folder
        private void createHiddenDirectory(string dirPath) {

            //If the folder exisits, delte the contents of the folder
            if (Directory.Exists(dirPath)) {

                DirectoryInfo toDelete = new DirectoryInfo(dirPath);
                clearFolder(toDelete);

                //Make sure the current folder is hidden
                toDelete.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            }
            
            //If the folder doesn't exist make a new one and hide it
            else {
                DirectoryInfo di = Directory.CreateDirectory(dirPath);

                //Set folder to hidden
                di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
            }
        }


        //Delete all files in a folder
        private void clearFolder(DirectoryInfo dir) {
            
            //Get all folders in the folder
            DirectoryInfo[] containedFolders = dir.GetDirectories();

            //Delete all subfolders contained within the folder
            if (containedFolders.Length != 0) {
                foreach (DirectoryInfo dir2 in containedFolders) {
                    clearFolder(dir2);
                    dir2.Delete();
                }
            }

            //Delete all files
            foreach (FileInfo file in dir.GetFiles()) {
                file.Delete();
            }
        }


        //Generate a new script based on machine selected
        private string[] genScript(string machine) {

            //Generate custom script based on machine
            Script scr = new Script(machine);

            //Return each line of the script
            return scr.getFileContents();
        }


        //Clean up the start up
        public void cleanUp() 
        {
            //Path to start up for selected operating system
            string deletePath = String.Format("{0}SOSU.vbs", this.selectedSystemPath);
            //Delete the script in start up
            if (File.Exists(deletePath))
            {
                File.Delete(deletePath);
            }
            DirectoryInfo backupFolder = new DirectoryInfo(@"C:\" + this.selectedUnit + " backup");
            clearFolder(backupFolder);
            backupFolder.Delete();
        }
    }
}
