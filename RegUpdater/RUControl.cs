using System;
using System.Collections.Generic;
using Microsoft.Win32;


/**********************************************\
 *ENGINEER REGISTRY UPDATER                    *
 *Version: 1.0.0                               *
 *Written for: Snap-On Diagnostics             *
 *Written by: Jamie Woods                      *
 *On: 08/04/2014                               *
 \*********************************************/


namespace RegUpdater 
{


    public class RUControl
    {


        //Object to store instance of location and all relevant details
        private struct RegLocation 
        {
            public RegLocation(string[] inData, RegOption[] opts) 
            {
                locationName = inData[0];
                subKey = inData[1];
                exeKey = inData[2];
                programKey = inData[3];
                options = opts; 
            }

            public string locationName;
            public string subKey;
            public string exeKey;
            public string programKey;
            public RegOption[] options; //All relevant options for this field
        }


        //Object to store instance of an option and all relevant details
        private struct RegOption 
        {
            public RegOption(string[] optionData) 
            {
                optionName = optionData[0];
                optionType = optionData[1];
                winXPExePath = optionData[2];
                winXPProgramPath = optionData[3];
                win7ExePath = optionData[4];
                win7ProgramPath = optionData[5];
            }

            public string optionName;
            public string optionType;
            public string winXPExePath;
            public string winXPProgramPath;
            public string win7ExePath;
            public string win7ProgramPath;
        }


        //Object to store instance of operating system choice
        private struct OpSys 
        {
            public OpSys(string op) 
            {
                operatingSystem = op;
            }

            public string operatingSystem;
        }


        //All the avalible locations the user can choose
        private RegLocation[] locations; 
        

        //Currently selected fields
        private RegLocation selectedLoc; 
        private RegOption selectedOpt;
        private OpSys selectedSystem;


        //Read and display the data from internal source
        public List<string> getData() 
        {
            //Read the unfiltered options from data, then filter and store
            List<RegOption[]> avalibleOptions = getOptions();

            //Read location data and create object array of each avalible choice
            List<RegLocation> locationList = new List<RegLocation>();
            foreach (string[] array in InternalData.locationData) 
            {
                //Select the correct set of options for the machine
                RegOption[] options = allOptionsSearch(avalibleOptions, array[0]);
                
                RegLocation loc = new RegLocation(array, options);
                locationList.Add(loc);
            }
            this.locations = locationList.ToArray();

            //Return list of each avalible location
            List<string> avalibleLocations = new List<string>();
            foreach (RegLocation loc in locationList) {
                string output = loc.locationName;
                avalibleLocations.Add(output);
            }
            return avalibleLocations;
        }


        //Read all options from internal data
        private List<RegOption[]> getOptions() 
        {
            //Read unfiltered options from data
            List<RegOption> unfiltered = new List<RegOption>();
            foreach (string[] data in InternalData.optionData) 
            {
                RegOption opt = new RegOption(data);
                unfiltered.Add(opt);
            }

            //Read all the avalible types the options can be filtered to
            List<string> optionTypes = new List<string>();
            foreach (RegOption opt in unfiltered) {
                string type = opt.optionType;

                //Check the option hasn't already been added
                if (!optionTypes.Contains(type)) {
                    optionTypes.Add(type);
                }
            }

            //Sort the options into different arrays based on their type property
            List<RegOption[]> filtered = new List<RegOption[]>();
            foreach (string str in optionTypes) {
                List<RegOption> filt = filterOptions(unfiltered, str);
                RegOption[] option = filt.ToArray();
                filtered.Add(option);
            }
            return filtered;
        }


        //Read operating systems from internal data and pass list
        public List<string> getOperatingSystems() 
        {
            List<string> opData = new List<string>();
            foreach (string op in InternalData.opSysData) 
            {
                opData.Add(op);
            }
            return opData;
        }


        //Write the selected values to the registry
        public bool updateReg(out string errorMessage) 
        {
            try 
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(selectedLoc.subKey, true)) 
                {
                    //If key opening fails the object returns null
                    if (key == null) {
                        errorMessage = "Key not found!";
                        return false;
                    }

                    //Select the correct option based on users operating system selection
                    string exePath;
                    string programPath;
                    if (selectedSystem.operatingSystem == "Windows XP") 
                    {
                        exePath = selectedOpt.winXPExePath;
                        programPath = selectedOpt.winXPProgramPath;
                    } 
                    else if (selectedSystem.operatingSystem == "Windows 7")
                    {
                        exePath = selectedOpt.win7ExePath;
                        programPath = selectedOpt.win7ProgramPath;
                    } 
                    else 
                    {
                        errorMessage = "ERROR: Could not update";
                        return false;
                    }

                    //Write values to the registry;
                    key.SetValue(selectedLoc.exeKey, exePath, RegistryValueKind.String);
                    key.SetValue(selectedLoc.programKey, programPath, RegistryValueKind.String);

                    errorMessage = "";
                    return true;
                }
            }
            catch(System.Security.SecurityException ex){
                errorMessage = ex.Message + "\n\nTry running as admin";
                return false;
            }
            
        }


        //Update the window based on the location selected
        public List<string> updateWindow(string locString) 
        {
            RegLocation loc = searchLocations(locString);
            this.selectedLoc = loc;
            List<string> avalibleOptions = new List<string>();

            //Write the avalible options to option combobox 
            foreach (RegOption opt in loc.options)
            {
                string output = opt.optionName;
                avalibleOptions.Add(output);
            }

            return avalibleOptions;
        }


        //Set the selected option
        public void updateOption(string name)
        {
            RegOption opt = optionSearch(this.selectedLoc.options, name);
            selectedOpt = opt;
        }


        //Set the selected operating system
        public void updateOpSys(string updateTo)
        {
            this.selectedSystem = new OpSys(updateTo);
        }


        //Search the unfiltered options and return list of options with matching type, replaces Linq query
        private List<RegOption> filterOptions(List<RegOption> unfiltered, string compareValue) 
        {
            List<RegOption> selectedOpts = new List<RegOption>();
            foreach (RegOption opt in unfiltered) 
            {
                if (opt.optionType == compareValue) 
                {
                    selectedOpts.Add(opt);
                }
            }

            return selectedOpts;
        }


        //Search all locations and return object with matching name, replaces Linq.Single
        private RegLocation searchLocations(string compareValue) {
            foreach (RegLocation loc in this.locations) {
                if (loc.locationName == compareValue) {
                    return loc;
                }
            }
            return new RegLocation();
        }


        //Search all the options and return the set with matching type, replaces Linq.Single
        private RegOption[] allOptionsSearch(List<RegOption[]> allOptions, string compareValue)
        {
            foreach (RegOption[] optSet in allOptions) 
            {
                if (optSet[0].optionType == compareValue) 
                {
                    return optSet;
                }
            }

            return null;
        }


        //Search the selected options, replaces Linq.Single
        private RegOption optionSearch(RegOption[] optionArray, string compareValue)
        {
            foreach (RegOption opt in this.selectedLoc.options) 
            {
                if (opt.optionName == compareValue)
                {
                    return opt;
                }
            }

            return new RegOption();
        }       
    }
}
