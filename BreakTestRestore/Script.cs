using System;
using System.Collections.Generic;

/**********************************************\
 *BRAKE TEST RESTORER                          *
 *Version: 1.0.0                               *
 *Written for: Snap-On Diagnostics             *
 *Written by: Jamie Woods                      *
 *On: 08/04/2014                               *
 *                                             *
 * Script Version: 1.0                         *
 * Updated: 14/04/14                           *
 \*********************************************/

namespace BrakeTestRestore {

    class Script {

        //Change relevent sections of the script based on selected machine
        public Script(string machine) {
            changeSymbol(ref this.copyLog, machine);
            changeSymbol(ref this.backup, machine);
            changeSymbol(ref this.timeStampFile, machine);
        }


        //Identification header for the script
        private string[] header = {
            "'####################################################'",
            "'Script to deal with restoring break tester log files'",
            "'Written by: Jamie Woods                             '",
            "'For: Snap-On Diagnostics                            '",
            "'On: 10/04/2014                                      '",
            "'Auto-generated code                                 '",
            "'####################################################'",
            ""
        };


        //Set the fso and copy the logfile into the log folder
        private string[] copyLog = {
            "",
            "IF Not (objFSO.FileExists(\"C:\\^\\comunlog.txt\")) Then",
            "\tWScript.Quit()",
            "End If",
            "",
            "Set objFSO = CreateObject(\"Scripting.FileSystemObject\")",
            "ObjFSO.Copyfile \"C:\\^\\comunlog.txt\" , \"C:\\^\\logfile\\\" , true",
            ""
        };


        //VBS function to add a zero to the front of single didget numbers
        private string[] funcLeadingZero = {
            "",
            "Function leadingZero(num)",
            "\tDim tempVal",
            "\tIf isnumeric(num) Then",
            "\t\tIf num < 10 Then",
            "\t\t\ttempVal = \"0\" & num",
            "\t\tElse",
            "\t\t\ttempVal = CStr(num)",
            "\t\tEnd if",
            "\tElse",
            "\t\ttempVal = Null",
            "\tEnd if",
            "\tleadingZero = tempVal",
            "End Function",
            ""
        };


        //Time stamp the logfile to keep an archive
        private string[] timeStampFile = {
            "",
            "Dim currentTime",
            "currentTime = Now",
            "Dim timeStamp",
            "timeStamp = day(currentTime)", 
            "timeStamp = timeStamp & leadingZero(Month(currentTime))",
            "timeStamp = timeStamp & leadingZero(Year(currentTime))",
            "timeStamp = timeStamp & leadingZero(Hour(currentTime))",
            "timeStamp = timeStamp & leadingZero(Minute(currentTime))",
            "objFSO.CopyFile \"c:\\^\\logfile\\comunlog.txt\", \"c:\\^\\logfile\\comunlog_\" & timeStamp & \".txt\"",
            ""
        };


        //Copy essential files to the backup folder, overwriting old versions
        private string[] backup = {
            "",
            "ObjFSO.Copyfile \"C:\\^ backup\\*.exe\" , \"C:\\^\\\" , true",
            "ObjFSO.Copyfile \"C:\\^ backup\\language\\*.gbr\" , \"C:\\^\\language\\\" , true",
            "ObjFSO.Copyfile \"C:\\^ backup\\config\\*.gbr\" , \"C:\\^\\config\\\" , true",
        };


        //Go through a block of code checking for the escape charector, changing it to the relevant path
        private void changeSymbol(ref string[] codeBlock, string changeTo) {

            //Check each line of the block of code
            for (int count1 = 0; count1 < codeBlock.Length; count1++) {

                //Check for escape charector
                if (codeBlock[count1].Contains("^")) {

                    //Rewrite line with correct path
                    codeBlock[count1] = changeLine(codeBlock[count1], changeTo);
                }
            }
        }


        private string changeLine(string line, string newValue) {

            char[] lineSections = line.ToCharArray();
            string newLine = "";

            //If the char is an escape charector write the new value to the line
            //Else write the same as before
            for (int count1 = 0; count1 < lineSections.Length; count1++) {

                if (lineSections[count1] == '^') {
                    newLine += newValue;
                    continue;
                } else {
                    newLine += lineSections[count1].ToString();
                }
            }

            return newLine;
        }


        //Get the entire script ready for printing to file
        public string[] getFileContents() {

            List<string> fileContents = new List<string>();

            addToList(header, ref fileContents);
            addToList(copyLog, ref fileContents);
            addToList(funcLeadingZero, ref fileContents);
            addToList(timeStampFile, ref fileContents);
            addToList(backup, ref fileContents);

            return fileContents.ToArray();
        }


        //Add the selected block of code to the list
        private void addToList(string[] codeLines, ref List<string> fileContents) {

            foreach (string value in codeLines) {
                fileContents.Add(value);
            }
        }
    }
}