using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLSM_Calc
{
    public class SubNet : Net
    {
        public string Name { get; set; }
        public int Hosts { get; set; }
        public IP FirstIP { get; set; }
        public IP LastIP { get; set; }
        public IP Broadcast { get; set; }

        public SubNet(IP ip, int mask, int level, string name, int hosts) : base(ip, mask, level)
        {
            Name = name;
            Hosts = hosts;
            FirstIP = null;
            LastIP = null;
            Broadcast = null;
        }

        public SubNet(string name, int hosts) : base((IP)null, 0, 0)
        {
            Name = name;
            Hosts = hosts;
            FirstIP = null;
            LastIP = null;
            Broadcast = null;
        }

        public void CalculateBroadcast(int octetsNum)
        {
            Broadcast = new IP(NetIP.getIP());
            int hosts = (int)Math.Pow(2, 32 - Mask) - 2;
            int sum = 0;
            if (octetsNum == 1)
            {
                sum = hosts + 1;
            }
            else
            {
                sum = hosts / (int)Math.Pow(256, (octetsNum - 1));
            }
            Broadcast.Octets[4 - octetsNum] += sum;
            for (int i = 4 - octetsNum + 1; i < 4; i++)
            {
                Broadcast.Octets[i] = 255;
            }
        }

        public void CalculateFirstIP()
        {
            FirstIP = new IP(NetIP.getIP());
            FirstIP.Octets[3]++;
        }

        public void CalculateLastIP()
        {
            LastIP = new IP(Broadcast.getIP());
            LastIP.Octets[3]--;
        }

        public string printSubNet()
        {
            return Name + " hosts requeridos: " + Hosts + "\n" +
                "Direccion de red: " + NetIP.getIP() + "/" + Mask + "\n" +
                "Primera IP: " + FirstIP.getIP() + "\n" +
                "Ultima IP: " + LastIP.getIP() + "\n" +
                "Broadcast: " + Broadcast.getIP() + "\n";
        }
    }
}
