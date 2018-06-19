using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Win32;
using System.Management;
using System.Diagnostics;

namespace CardWriter
{

    public class crControl
    {

        frmCardWriter gui;

        const string CARD_WRITE_ROOT = @"Install\CardWriter\";


        public crControl(frmCardWriter frmGUI) 
        {
            this.gui = frmGUI;
        }


        //Get the drive number of the sd Card;
        private bool getDriveNumber(out string diskNumber)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * From Win32_DiskDrive");

            foreach (ManagementObject obj in searcher.Get())
            {
                string diskName = obj.ToString();
                diskNumber = diskName.Substring(diskName.Length - 2, 1);

                foreach (PropertyData pd in obj.Properties)
                {
                    string pdValue;

                    try
                    {
                        pdValue = pd.Value.ToString();
                    }
                    catch (NullReferenceException ex)
                    {
                        pdValue = "Error!";
                    }

                    if (pdValue.Contains("SD "))
                    {
                        return true;
                    }
                }
            }
            diskNumber = "999";
            return false;
        }


        //Get the file to write to the card
        private string getFile(string folder)
        {
            try
            {
                string path = CARD_WRITE_ROOT + folder;

                string[] files = Directory.GetFiles(path);

                return files[0];
            }
            catch
            {
                throw new Exception("File not found!");
            }
        }


        //Clean the SD card, to enable write
        private void cleanSD(string diskNumber) 
        {
            string comLine1 = "select disk " + diskNumber;

            Process p = newProcess("diskpart.exe");
            p.Start();

            p.StandardInput.WriteLine(comLine1);
            p.StandardInput.WriteLine("clean");
            p.StandardInput.WriteLine("exit");

            p.WaitForExit();
        }


        //Create a new process
        public Process newProcess(string file) 
        {
            Process p = new Process();

            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.FileName = file;

            return p;
        }


        //Control the update process
        public bool updateControl(string selectedOption, out string errorFlag,
                                  out string command,    out string driveNumber,
                                  out string file) 
        {
            try 
            { 
                command = @"Install\CardWriter\CFwrite.exe";

                if(!getDriveNumber(out driveNumber))
                {
                    throw new Exception("SD card not found!");
                }

                cleanSD(driveNumber);

                file = getFile(selectedOption);

                string para = driveNumber + " " + file;
        
                

                errorFlag = null;
                return true;
            }
            catch (Exception ex)
            {
                errorFlag = ex.Message;
                command = "";
                driveNumber = "";
                file = "";
                return false;
            }
        }
    }
}
