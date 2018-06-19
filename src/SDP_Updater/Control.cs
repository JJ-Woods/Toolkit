using System;
using System.Collections.Generic;
using System.IO;

/**********************************************\
 *SDP Updater                                  *
 *Version: 1.0.0                               *
 *Written for: Snap-On Diagnostics             *
 *Written by: Jamie Woods                      *
 *On: 08/04/2014                               *
 \*********************************************/

namespace SDP_Update{

    public class SDPUControl{


        private const string updateRoot = @"Updates";

        private string version;


        public string versionPub {
            set {
                this.version = value;
            }
        }


        //Get all avalible updates
        public string[] getUpdates(){

            DirectoryInfo di = new DirectoryInfo(updateRoot);

            //Get each sub-folder name (Update version)
            string[] updates = subFolderNames(di);

            return updates;
        }


        //Return all the names of subfolders within a parent
        private string[] subFolderNames(DirectoryInfo parentFolder) {

            List<string> names = new List<string>();

            try {

                foreach (DirectoryInfo dir in parentFolder.GetDirectories()) {
                    string name = dir.Name;
                    names.Add(name);
                }

            } catch (DirectoryNotFoundException ex) {

                string [] errorArray = {"No options found!!"};
                return errorArray;
            }

            return names.ToArray();
        }


        //Copy the selected update folder to the SDP program files
        public void copyUpdate() {

            const string dest = @"C:\Program Files\Snap-On Technologies Inc\Sun Diagnostic Platform";
            string sourcePath = updateRoot + @"\" + this.version;

            copyFolder(sourcePath, dest);
        }


        //Copy one folder from source to destination including all subfolders and their contents
        private void copyFolder(string folderPath, string folderDest) {

            //Set up the folder objects from parameter
            DirectoryInfo source = new DirectoryInfo(folderPath);
            getInfo(folderDest);

            //Copy all subfolders
            string[] sourceSubNames = subFolderNames(source);
            
            foreach(string subName in sourceSubNames) {

                string sourcePath = folderPath + @"\" + subName;
                string destPath = folderDest + @"\" + subName;

                //Make folder if it doesn't exist
                getInfo(destPath); 

                //Recursivly call function to copy subfolder
                copyFolder(sourcePath, destPath);
            }

            //Copy all files in source folder to destination folder
            foreach (FileInfo file in source.GetFiles()) {

                string sourcePath = file.FullName;
                string destPath = folderDest + @"\" + file.Name;

                File.Copy(sourcePath, destPath, true);
            }
        }


        //If the folder doesn't exist, make it and return the info
        private DirectoryInfo getInfo(string folderPath) {
            
            if (!Directory.Exists(folderPath)) {
                DirectoryInfo newFolder = Directory.CreateDirectory(folderPath);
            }

            return new DirectoryInfo(folderPath);
        }
    }
}
