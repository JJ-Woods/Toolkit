using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.Windows.Forms;

/**********************************************\
 *LANGUAGE PATCH                               *
 *Version: 1.0.0                               *
 *Written for: Snap-On Diagnostics             *
 *Written by: Jamie Woods                      *
 *On: 08/04/2014                               *
 \*********************************************/

namespace LanguageUpdater{

    public class LUControl{

        const string FOLDER = @"C:\Program Files\Snap-on Technologies Inc\ThunderCloud";


        //Complete the language update
        public void doUpdate() {

            if (!Directory.Exists(FOLDER)) {
                MessageBox.Show("Thundercloud not installed");
                return;
            }

            copyUpdatedLanguages();
            updateXML();
        }


        //Copy the updated languages file
        private void copyUpdatedLanguages() {
            
            const string updateLocation = @"Updates\Languages.xml";
            File.Copy(updateLocation, FOLDER + @"\Languages.xml", true);
        }


        //Update the faulty xml file
        private void updateXML() {

            const string path = FOLDER + @"\Pro32Config.xml";

            string[] xmlContents = getFile(path);

            changeNode(ref xmlContents, "ScreenLanguage", "    <ScreenLanguage>English</ScreenLanguage>");
            changeNode(ref xmlContents, "HelpLanguage", "    <HelpLanguage>eng</HelpLanguage>");

            writeFile(path, xmlContents);
        }


        //Get each line of the file
        private string[] getFile(string path){

            List<string> contents = new List<string>();

            if (!File.Exists(path)) {
                return null;
            }

            using (StreamReader reader = new StreamReader(path)) {
                
                while (reader.Peek() > 0) {
                    string line = reader.ReadLine();
                    contents.Add(line);
                }
            }

            return contents.ToArray();
        }


        //Change one line of the file pased on parameters
        private void changeNode(ref string[] fileContents, string node, string changeTo) {

            for (int count1 = 0; count1 < fileContents.Length; count1++) {

                if (fileContents[count1].Contains(node)){ 

                    fileContents[count1] = changeTo;

                    break;
                } 
            }
        }


        //Write the array to file
        private void writeFile(string path, string[] fileContents) {

            using (StreamWriter writer = new StreamWriter(path)) {

                foreach (string line in fileContents) {

                    writer.WriteLine(line);
                }
            }
        }
    }
}
