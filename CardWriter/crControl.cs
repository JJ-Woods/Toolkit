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

        const string CARD_WRITE_ROOT = @"Install\CardWriter\";            


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


        //Run the update
        private void runUpdate(string command, string param)
        {
            ProcessStartInfo info = new ProcessStartInfo(command, param);
            Process p = new Process();
            p.StartInfo = info;
            p.Start();
            p.WaitForExit();
        }

        //Control the update process
        public bool updateControl(string selectedOption, out string errorFlag) 
        {
            try 
            { 
                const string command = @"Install\CardWriter\CFwrite.exe";
                string driveNumber;
                string file;

                if(!getDriveNumber(out driveNumber))
                {
                    throw new Exception("SD card not found!");
                }

                file = getFile(selectedOption);

                string para = driveNumber + " " + file;
        
                runUpdate(command, para);

                errorFlag = null;
                return true;
            }
            catch (Exception ex)
            {
                errorFlag = ex.Message;
                return false;
            }
        }
    }
}
