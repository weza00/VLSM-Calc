using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLSM_Calc
{
    public class Net
    {
        public IP NetIP { get; set; }
        public int Mask { get; set; }
        public int Level { get; set; }
        public Net(IP ip, int mask, int level)
        {
            NetIP = ip;
            Mask = mask;
            Level = level;
        }
        public Net(string ip, int mask, int level)
        {
            NetIP = new IP(ip);
            Mask = mask;
            Level = level;
        }
        public string getNet()
        {
            return NetIP.getIP() + "/" + Mask.ToString();
        }
    }
}
