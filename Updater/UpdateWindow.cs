using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

/**********************************************\
 *TOOLKIT UPDATER                              *
 *Version: 1.0.0                               *
 *Written for: Snap-On Diagnostics             *
 *Written by: Jamie Woods                      *
 *On: 14/04/2014                               *
 \*********************************************/

namespace Updater {

    //Program updates toolkit, taking relevent exes and dlls and putting into install folder
    //And relevant source and puts it into a source folder
    public partial class frmUpdateWindow : Form {

        //Structure to store on source folder and its contents
        private struct Source {

            //Structure to store one source file within the folder
            public struct SourceFile {

                public SourceFile(string name, string location) {
                    fileName = name;
                    fileLocation = location;
                }

                public string fileName;
                public string fileLocation;
            }

            public Source(string folder, SourceFile[] fileArray) {
                sourceFolder = folder;
                files = fileArray;
            }

            public string sourceFolder;
            public SourceFile[] files;
        }


        string[] binFiles;
        string[] installFiles;
        Source[] sourceFiles;


        public frmUpdateWindow(){

            InitializeComponent();

            //Read the data from the files
            readInstall();
            readSource();
        }


        //Read the install data from the file
        private void readInstall(){
            
            //Default paths for the install files
            const string binPath = @"C:\Users\Jamie\Desktop\Development\Snap-On\Toolkit\Toolkit\bin\Debug\";
            const string installPath = @"C:\Users\Jamie\Desktop\Development\Snap-On\Install\Toolkit\";

            //Lists of the files with relevant full paths
            List<string> fileList = new List<string>();
            List<string> installList = new List<string>();

            //Read from the file
            using (StreamReader reader = new StreamReader(new FileStream("InstallFiles.txt", FileMode.Open))) {
                while (reader.Peek() > 0) {
                    
                    string file = reader.ReadLine();

                    lsbInstall.Items.Add(file);

                    //Format the file with its full path
                    string filePath = binPath + file;
                    fileList.Add(filePath);
                    string install = installPath + file;
                    installList.Add(install);
                }
            }

            //Store the files with the full path in the lists
            this.binFiles = fileList.ToArray();
            this.installFiles = installList.ToArray();
        }


        //Read the source data from the file
        private void readSource() {

            List<Source> sourceList = new List<Source>();

            using (StreamReader reader = new StreamReader(new FileStream("SourceFiles.txt", FileMode.Open))) {
                
                while (reader.Peek() > 0) {
                    Source temp = readSourceFolder(reader);
                    sourceList.Add(temp);
                    reader.ReadLine(); //Line break in file structure
                }
            }

            //Format the data for disply in the list box
            foreach (Source sour in sourceList) {
                string output = sour.sourceFolder;
                lsbSourceDir.Items.Add(output);
            }

            this.sourceFiles = sourceList.ToArray();
        }


        //Read one folder and store in object
        private Source readSourceFolder(StreamReader reader) {

            //Read the constant data header
            string folderName = reader.ReadLine();
            int numberOfFiles = int.Parse(reader.ReadLine());

            Source.SourceFile[] files = new Source.SourceFile[numberOfFiles];

            //Read the correct number of files in the folder
            for (int count1 = 0; count1 < numberOfFiles; count1++) {
                //Read file data
                string name = reader.ReadLine();
                string loc = reader.ReadLine();

                //Store as object and store the object in array
                files[count1] = new Source.SourceFile(name, loc);
            }

            //Create object of the folder and the files contained within it
            return new Source(folderName, files);
        }


        //Differnet source folder selected, display all files within that folder
        private void lsbSourceDir_SelectedIndexChanged(object sender, EventArgs e) {

            //Clear the previous files from the output
            lsbSourceFiles.Items.Clear();

            //Select folder object based on unique folder name
            string folder = lsbSourceDir.SelectedItem.ToString();
            Source selectedSource = sourceFiles.Single(f => f.sourceFolder == folder);

            //Output each file in the folder object to listbox
            foreach (Source.SourceFile file in selectedSource.files) {
                string output = file.fileName;
                lsbSourceFiles.Items.Add(output);
            }
        }


        //Update button pressed, do update
        private void btnUpdate_Click(object sender, EventArgs e) {
            copyInstalls();
            copySource();
            MessageBox.Show("Update Complete!");
        }

        //Copy all the install files from the bin folder to the install folder
        private void copyInstalls() {
            
            //Copy each file
            for (int count1 = 0; count1 < this.binFiles.Length; count1++) {
                //Overwrite old files
                File.Copy(this.binFiles[count1], this.installFiles[count1], true);
            }
        }


        //Copy all source files from their locations, rename and put into correct folder
        private void copySource() {

            //Default source folder location
            const string sourceFolder = @"C:\Users\Jamie\Desktop\Development\Snap-On\Source\";

            foreach (Source sor in sourceFiles) {
                //Get the folder name
                string folderPath = sourceFolder + sor.sourceFolder;

                //If the folder isn't present, create the folder
                if (!Directory.Exists(folderPath)) {
                    DirectoryInfo di = Directory.CreateDirectory(folderPath);
                }

                //Copy each folder from its location to the correct source subfolder
                foreach (Source.SourceFile file in sor.files) {
                    string dest = folderPath + @"\" + file.fileName;
                    File.Copy(file.fileLocation, dest, true);
                }
            }
        }
    }
}
