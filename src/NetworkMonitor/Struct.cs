public struct NetworkDevice
{
    private string machineName;
    private string ipv4;
    private string mac;
    private string type;
    private string nicManufactorer;
    private string responseTime;
    private string notes;

    public NetworkDevice(string mn, string ip, string mc, string tp, string nic, string resTime, string note) 
    {
        this.machineName = mn;
        this.ipv4 = ip;
        this.mac = mc;
        this.type = tp;
        this.nicManufactorer = nic;
        this.responseTime = resTime;
        this.notes = note; 
    }

    public string getMachineName() 
    {
        return this.machineName;
    }

    public string getIpv4()
    {
        return this.ipv4;
    }

    public string getMac() 
    {
        return this.mac;
    }

    public string getType() 
    {
        return this.type;
    }

    public string getNicManufactorcer() 
    {
        return this.nicManufactorer;
    }

    public string getResponseTime() 
    {
        return this.responseTime;
    }

    public string getNotes() 
    {
        return this.notes;
    }
}