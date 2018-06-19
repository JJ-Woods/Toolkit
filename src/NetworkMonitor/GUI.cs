using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace NetworkMonitor
{
    public partial class frmNetworkMonitor : Form 
    {
        private LocalNetworkControl control;
        private List<NetworkDevice> networkDevices;

        delegate void ClearDGVCallback();
        delegate void AddToDGVCallback(string name, string ip,      string mac, 
                                       string type, string nicManu, string responseTime,
                                       string notes);

        public frmNetworkMonitor() 
        {
            InitializeComponent();
            this.control = new LocalNetworkControl();
        }


        private void frmNetworkMonitor_Shown(object sender, EventArgs e)
        {
                updatePCList();
        }


        //Update the list of networked pcs
        private void updatePCList()
        {
            Thread t = new Thread(() => updateWorker());
            try 
            {
                clearDataGridView();
                addToDataGridView("Update in progress...", "", "", "", "", "", "");

                t.Start();
            }
            catch
            {
                if (t.IsAlive) 
                {
                    t.Abort();
                }
                clearDataGridView();
                addToDataGridView("Network Error!!", "Please refresh.", "If errors persist check network", "", "", "", "");
            }
        }

        
        private void updateWorker() 
        {
            getNetworkPCs();

            clearDataGridView();

            foreach (NetworkDevice device in this.networkDevices)
            {
                addToDataGridView(device.getMachineName(), device.getIpv4(),             device.getMac(), 
                                  device.getType(),        device.getNicManufactorcer(), device.getResponseTime(),
                                  device.getNotes());
            }
        }


        //Get network pcs from control object
        private void getNetworkPCs() 
        {
            this.control.updateNetworkDevices();
            
            this.networkDevices = null;
            this.networkDevices = this.control.getNetworkDevices();

            if (this.networkDevices.Count == 0) 
            {
                this.networkDevices.Add(new NetworkDevice("Network error", "Please refresh", 
                                                  "If error persists check network", "", "", "", ""));
            }
        }


        private void clearDataGridView() 
        {
            if (this.dgvLocalNetwork.InvokeRequired) 
            {
                ClearDGVCallback d = new ClearDGVCallback(clearDataGridView);
                this.Invoke(d);
            }
            else
            {
                this.dgvLocalNetwork.Rows.Clear();
            }
        }


        private void addToDataGridView(string name, string ip,  string mac, 
                                       string type, string nic, string response,
                                       string notes) 
        {
            if (this.dgvLocalNetwork.InvokeRequired) 
            {
                AddToDGVCallback d = new AddToDGVCallback(addToDataGridView);
                this.Invoke(d, name, ip, mac, type, nic, response, notes);
            }
            else
            {
                this.dgvLocalNetwork.Rows.Add(name, ip, mac, type, nic, response, notes);
            }
        }

       
        private void btnRefresh_Click(object sender, EventArgs e) 
        {
            updatePCList();
        }


        private void dgvOutput_SelectionChanged(object sender, EventArgs e) 
        {
            dgvLocalNetwork.ClearSelection();
        }
    }
}
