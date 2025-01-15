using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLSM_Calc
{
    internal class Net
    {
        public IP NetIP { get; set; }
        public int Mask { get; set; }
        public Net(IP ip, int mask)
        {
            NetIP = ip;
            Mask = mask;
        }
        public string getNet()
        {
            return NetIP.getIP() + "/" + Mask.ToString();
        }
    }
}
