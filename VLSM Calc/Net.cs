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
        public string getNet(int octetsNum)
        {
            string init = "";
            string final = NetIP.getIP() + " /" + Mask.ToString();
            string ident = "";
            for (int i = 0; i < 4 - octetsNum; i++)
            {
                init += NetIP.Octets[i].ToString() + ".";
            }
            for (int i = 4 - octetsNum; i < 4; i++)
            {
                if (i == 3)
                    init += NetIP.getBinaryOctet(i);
                else
                    init += NetIP.getBinaryOctet(i) + ".";
            }
            for (int i = 0; i < Level; i++)
            {
                ident += "  ";
            }
            return ident + init + "\t\t" + final;
        }
    }
}
