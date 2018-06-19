using System;
using System.Collections.Generic;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace NetworkMonitor
{
    public class LocalNetworkControl
    {
        private List<NetworkDevice> networkDevices;
        private List<string> namedDevices;

        public List<NetworkDevice> getNetworkDevices() 
        {
            return this.networkDevices;
        }


        //Create a new process to execute dos commands
        private ProcessStartInfo newCMD(string command)
        {
            ProcessStartInfo procInfo = new ProcessStartInfo("cmd", "/c" + command);
            procInfo.CreateNoWindow = true;
            procInfo.UseShellExecute = false;
            procInfo.RedirectStandardOutput = true;
            return procInfo;
        }


        //Check if given string is null or only white space
        bool isNullOrWhiteSpace(string value)
        {
            if (value == null)
            {
                return true;
            }

            foreach (char ch in value) 
            {
                if (!Char.IsWhiteSpace(ch))
                {
                    return false;
                }
            }

            return true;
        }


        //Update the list of network devices
        public void updateNetworkDevices()
        {
            this.networkDevices = new List<NetworkDevice>();
            this.namedDevices = new List<string>();

            Thread getThisDeviceW = new Thread(() => getThisDevice());
            getThisDeviceW.Start();

            Thread getNamedDevicesW = new Thread(() => getNamedDevices());
            getNamedDevicesW.Start();

            List<string> arpData = chunkArpData(getUnformattedArpData());

            getNamedDevicesW.Join();

            List<Thread> threadList = new List<Thread>();
            foreach (string arpLine in arpData) 
            {
                Thread t = new Thread(() => addNetworkDevice(arpLine));
                threadList.Add(t);
            }
            foreach (Thread t in threadList) 
            {
                t.Start();
            }
            foreach (Thread t in threadList) 
            {
                t.Join();
            }

            getThisDeviceW.Join();

            purgeTheWeak();
            this.networkDevices.Sort((x, y) => string.Compare(x.getIpv4(), y.getIpv4()));
        }


        //Get device details for this device
        private void getThisDevice() 
        {
            string machineName = "";
            string ip = "";
            string mac = "";
            string type = "";
            string nicManu = "";
            string responseTime = "";
            string notes = "";

            machineName = getHostname();
            getThisArp(out ip, out mac, out type);
            nicManu = getNIC(mac);
            responseTime = "N/A";
            notes = "This PC"; 

            NetworkDevice dev = new NetworkDevice(machineName, ip, mac, type, nicManu, responseTime, notes);
            lock (this.networkDevices) 
            {
                this.networkDevices.Add(dev);
            }
        }


        //Get the arp data of this device
        private void getThisArp(out string ip, out string mac, out string type) 
        {
            Process proc = Process.Start(newCMD("ipconfig /all"));
            proc.WaitForExit();
            string cmdOut = proc.StandardOutput.ReadToEnd();

            List<string> networkAdaptors = parseIpConfig(cmdOut);
            string correctAdaptor = "";
            foreach (string adaptor in networkAdaptors) 
            {
                if (adaptor.Contains("IPv4 Address")) 
                {
                    correctAdaptor = adaptor;
                    break;
                }   
            }
   
            parseAdaptorInfo(correctAdaptor, out ip, out mac, out type);
        }


        //Parse cmd output of ipconfig to get each network adaptor
        private List<string> parseIpConfig(string unformatted) 
        {
            List<string> chunks = new List<string>();

            int loc = unformatted.IndexOf("adapter") + "adapter".Length;

            string extracted = unformatted.Substring(0, loc).Trim();
            string remaining = unformatted.Substring(loc);

            chunks.Add(extracted);

            if (remaining.Contains("adapter")) 
            {
                chunks.AddRange(parseIpConfig(remaining));
            } 
            else 
            {
                chunks.Add(remaining.Trim());
            }

            return chunks;
        }


        //Parse adaptor chuck
        private void parseAdaptorInfo(string adaptor, out string ip, out string mac, out string type) 
        {
            ip = extractData(adaptor, "IPv4 Address");
            mac = extractData(adaptor, "Physical Address");

            string dhcpEnabled = extractData(adaptor, "DHCP Enabled");
            type = (dhcpEnabled == "Yes") ? "dynamic" : "static";
        }


        //Extract data from a dump based on a given string
        private string extractData(string toSearch, string searchFor)
        {
            int loc;
            string extracted = "";

            loc = toSearch.IndexOf(searchFor) + searchFor.Length;
            extracted = toSearch.Substring(loc);

            loc = extracted.IndexOf(":") + 2;
            extracted = extracted.Substring(loc).TrimStart();

            string returnVal = "";

            foreach (char ch in extracted) 
            {
                if (Char.IsWhiteSpace(ch) || ch == '(') 
                {
                    break;
                }
                returnVal += ch;
            }

            return returnVal;
        }


        //Get hostname of this pc
        private string getHostname() 
        {
            Process proc = Process.Start(newCMD("hostname"));
            proc.WaitForExit();
            string hostname = proc.StandardOutput.ReadToEnd();
            return hostname;
        }


        //Get named devices
        private void getNamedDevices() 
        {
            try 
            {
                Process proc = Process.Start(newCMD("net view /all"));
                proc.WaitForExit();
                string output = formatNetview(proc.StandardOutput.ReadToEnd());

                List<string> machineNames = parseMachineNames(output);

                for (int count1 = 0; count1 < machineNames.Count; count1++) 
                {
                    string ip = getIpNamedDevice(machineNames[count1]);
                    machineNames[count1] = String.Format("{0}:{1}#", machineNames[count1], ip);
                }

                this.namedDevices = machineNames;
            } 
            catch 
            {
                this.namedDevices = new List<string>();
            }
        }


        //Format output of netview
        private string formatNetview(string output) 
        {
            int loc = output.IndexOf("\\\\") + "\\\\".Length;
            output = output.Substring(loc);
            loc = output.IndexOf("The command completed successfully.");
            loc = (loc == -1) ? output.Length : loc;
            output = output.Substring(0, loc);
            return output;
        }


        //Parse the net view for visable machine names
        private List<string> parseMachineNames(string cmdDump) 
        {
            List<string> machineNames = new List<string>();

            int loc = cmdDump.IndexOf("\\\\") + "\\\\".Length;
            string extracted = cmdDump.Substring(0, loc);
            string remaining = cmdDump.Substring(loc);

            extracted = extracted.Trim();
            string tmp = "";
            foreach (char c in extracted) 
            {
                if (!Char.IsWhiteSpace(c)) 
                {
                    tmp += c;
                    continue;
                }
                break;
            }

            machineNames.Add(tmp);

            if (remaining.Contains("\\\\")) 
            {
                machineNames.AddRange(parseMachineNames(remaining));
            } 
            else
            {
                machineNames.Add(remaining.Trim());
            }

            return machineNames;
        }


        //Get ip address of named device
        private string getIpNamedDevice(string deviceName) 
        {
            string command = "ping " + deviceName + " -4 -n 1";
            ProcessStartInfo procInfo = newCMD(command);
            Process proc = Process.Start(procInfo);
            proc.WaitForExit();

            string ipv4 = proc.StandardOutput.ReadToEnd();
            ipv4 = parseIpv4(ipv4);

            return ipv4;
        }


        //Turn unformatted cmd dump of machine name ping into ipv4 address
        private string parseIpv4(string unformattedData) 
        {
            if (unformattedData.Contains("Ping request could not find host")) 
            {
                return "DISCONNECTED";
            }

            int leftBracket = unformattedData.IndexOf("[") + 1;
            int length = unformattedData.IndexOf("]") - leftBracket;
            string formatted = unformattedData.Substring(leftBracket, length);

            return formatted;
        }

        
        //Get arp data from cmd using the "arp -a" command
        private string getUnformattedArpData()
        {
            Process proc = Process.Start(newCMD("arp -a"));
            proc.WaitForExit();
            string output = proc.StandardOutput.ReadToEnd();
            return output;
        }


        //Format the arp data into a line by line, removing system messages
        private List<string> chunkArpData(string unformatted)
        {
            List<string> chunks = new List<string>();

            int dynamicLoc = unformatted.IndexOf("dynamic");
            int staticLoc = unformatted.IndexOf("static");

            dynamicLoc = (dynamicLoc == -1) ? staticLoc + 1
                                            : dynamicLoc;
            staticLoc = (staticLoc == -1) ? dynamicLoc + 1
                                            : staticLoc;

            int searchLoc = (dynamicLoc < staticLoc) ? dynamicLoc + "dynamic".Length
                                                     : staticLoc + "static".Length;
            string extracted = unformatted.Substring(0, searchLoc);
            string remaining = unformatted.Substring(searchLoc);

            chunks.Add(formatExtracted(extracted));

            if (!isNullOrWhiteSpace(remaining)) 
            {
                chunks.AddRange(chunkArpData(remaining));
            }

            return uniqueStringList(chunks);
        }


        //Remove system messages
        string formatExtracted(string extracted) 
        {
            if (extracted.Contains("Type"))
            {
                int loc = extracted.IndexOf("Type") + "Type".Length;
                extracted = extracted.Substring(loc);
            }
            extracted = extracted.Trim();

            return extracted;
        }


        //Remove any duplicate entries in list
        private List<string> uniqueStringList(List<string> unformatted) 
        {
            List<string> hashedList = new List<string>();
            foreach (string item in unformatted) 
            {
                if (!hashedList.Contains(item)) 
                {
                    hashedList.Add(item);
                }
            }
            return hashedList;
        }


        //Make a network device object from line of arp data
        private void addNetworkDevice(string arpInfo) 
        {
            string machineName = "";
            string ip = "";
            string mac = "";
            string type = "";
            string nicManu = "";
            string responseTime = "";
            string notes = "";

            parseArpData(arpInfo, out ip, out mac, out type);
            machineName = getMachineName(ip);
            nicManu = getNIC(mac);
            responseTime = getResponseTime(ip);

            notes = (ip == "192.168.0.1" || ip == "192.168.1.1")
                    ? "The router"
                    : "";
                        
            NetworkDevice dev = new NetworkDevice(machineName, ip, mac, type, nicManu, responseTime, notes);

            lock (this.networkDevices) 
            {
                networkDevices.Add(dev);
            }
        }

        
        //Parse data from arp string into ip, mac and type
        private void parseArpData(string arpLine, out string ip, out string mac, out string type) 
        {
            int locWhiteSpace = arpLine.IndexOf(' ');

            ip = arpLine.Substring(0, locWhiteSpace);
            arpLine = arpLine.Substring(locWhiteSpace).Trim();

            locWhiteSpace = arpLine.IndexOf(' ');

            mac = arpLine.Substring(0, locWhiteSpace).ToUpper();
            type = arpLine.Substring(locWhiteSpace).Trim();
        }


        //Find the machine name, if any, from the ip address
        private string getMachineName(string ip) 
        {
            string machineName = "";

            foreach (string machine in this.namedDevices)
            {
                string searchString = ip + "#";

                if (machine.Contains(searchString)) 
                {
                    int loc = machine.IndexOf(":");
                    machineName = machine.Substring(0, loc);
                    break;
                }
            }

            return machineName;
        }


        //Get the NIC manufactorer from MAC address, compare against oui records
        private string getNIC(string mac) 
        {
            string oui = mac.Substring(0, 8);
            string nicManu = "";

            using (StreamReader reader = new StreamReader("ouiReference.txt")) 
            {
                while (reader.Peek() != -1) 
                {
                    string tmp = reader.ReadLine();
                    nicManu = (tmp.Contains(oui)) ? tmp.Substring(11) : nicManu;
                }
            }

            nicManu = (nicManu == "") ? "Unknown" : nicManu;
            
            return nicManu;
        }


        //Get the response time by pinging the ip address
        private string getResponseTime(string ip) 
        {
            string command = "ping " + ip;
            Process proc = Process.Start(newCMD(command));
            proc.WaitForExit();
            string cmdOut = proc.StandardOutput.ReadToEnd();

            string response = (cmdOut.Contains("Approximate round trip times")) 
                               ? parseResponseTime(cmdOut) 
                               : "Timed out";
            
            return response;
        }


        //Parse the console window text from pinging
        private string parseResponseTime(string unformatted) 
        {
            string searchString = "Average";
            int loc = unformatted.IndexOf(searchString) + "Average = ".Length;
            unformatted = unformatted.Substring(loc);

            return unformatted;
        }


        //Remove useless NetworkDevice entries
        private void purgeTheWeak() 
        {
            for (int count1 = 0; count1 < this.networkDevices.Count; count1++) 
            {
                NetworkDevice tmpDevice = this.networkDevices[count1];
                if (tmpDevice.getType() == "static" && tmpDevice.getNicManufactorcer() == "Unknown") 
                {
                    this.networkDevices.RemoveAt(count1);
                    count1--;
                }
            }
        }
    }
}
