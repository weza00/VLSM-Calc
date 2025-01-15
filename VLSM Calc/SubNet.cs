using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLSM_Calc
{
    internal class SubNet : Net
    {
        public string Name { get; set; }
        public int Hosts { get; set; }
        public IP FirstIP { get; set; }
        public IP LastIP { get; set; }
        public IP Broadcast { get; set; }
        public SubNet(IP ip, int mask, string name, int hosts) : base(ip, mask)
        {
            Name = name;
            Hosts = hosts;
            FirstIP = null;
            LastIP = null;
            Broadcast = null;
        }
        public SubNet(string name, int hosts) : base(null, 0)
        {
            Name = name;
            Hosts = hosts;
            FirstIP = null;
            LastIP = null;
            Broadcast = null;
        }
    }
}
