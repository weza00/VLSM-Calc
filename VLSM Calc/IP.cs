using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLSM_Calc
{
    public class IP
    {
        public int[] Octets { get; set; }
        public IP()
        {
            Octets = new int[4] { 0, 0, 0, 0 };
        }
        public IP(int o1, int o2, int o3, int o4)
        {
            Octets = new int[4] { o1, o2, o3, o4 };
        }
        public IP(string ip)
        {
            string[] octets = ip.Split('.');
            Octets = new int[4] { int.Parse(octets[0]), int.Parse(octets[1]), int.Parse(octets[2]), int.Parse(octets[3]) };
        }
        public string getIP()
        {
            return Octets[0].ToString() + "." + Octets[1].ToString() + "." + Octets[2].ToString() + "." + Octets[3].ToString();
        }

        public string[] getBinaryRight(int num)
        {
            string[] binary = new string[num];
            for (int i = 0; i < num; i++)
            {
                binary[i] = Convert.ToString(Octets[i + (4 - num)], 2).PadLeft(8, '0');
            }
            return binary;
        }
        public IP Clone()
        {
            return new IP(Octets[0], Octets[1], Octets[2], Octets[3]);
        }
        public string getBinaryOctet(int octet)
        {
            return Convert.ToString(Octets[octet], 2).PadLeft(8, '0');
        }
        public void setBinaryOctet(int octet, string binary)
        {
            Octets[octet] = Convert.ToInt32(binary, 2);
        }
    }
}
