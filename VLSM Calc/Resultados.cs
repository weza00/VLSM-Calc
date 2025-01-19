using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Windows.Forms;

namespace VLSM_Calc
{
    public partial class Resultados : Form
    {
        private Net mainNet;
        private List<SubNet> subNets;

        public Resultados(Net mainNet, List<SubNet> subNets)
        {
            InitializeComponent();
            this.mainNet = mainNet;
            this.subNets = subNets;
            this.subNets = this.subNets.OrderByDescending(x => x.Hosts).ToList();
            VLSM();
        }

        public void VLSM()
        {
            int subNetCount = 0;
            Net actNet = mainNet;
            Stack<Net> stackNets = new Stack<Net>();
            int octetsNum = (int)Math.Ceiling((32 - (float)mainNet.Mask) / 8);

            while (subNetCount < subNets.Count)
            {
                if (actNet.Level == 0)
                {
                    string[] octets = actNet.NetIP.getBinaryRight(octetsNum);
                    string restBits = "";
                    for (int i = 0; i < (actNet.Mask % 8); i++)
                    {
                        restBits += octets[0][0];
                        octets[0] = octets[0].Remove(0, 1);
                    }

                    IP tempIP = actNet.NetIP.Clone();
                    for (int i = 0; i < octetsNum; i++)
                    {
                        if (i == 0)
                            tempIP.setBinaryOctet(i + (4 - octetsNum), restBits + octets[i]);
                        else
                            tempIP.setBinaryOctet(i + (4 - octetsNum), octets[i]);
                    }
                    Net first = new Net(tempIP.getIP(), actNet.Mask + 1, 1);
                    for (int i = 0; i < octetsNum; i++)
                    {
                        if (i == 0)
                            tempIP.setBinaryOctet(i + (4 - octetsNum), restBits + '1' + octets[i].Substring(1));
                        else
                            tempIP.setBinaryOctet(i + (4 - octetsNum), octets[i]);
                    }
                    Net second = new Net(tempIP.getIP(), actNet.Mask + 1, 1);
                    stackNets.Push(second);
                    actNet = first;
                }
                else
                {
                    if (Math.Pow(2, 32 - actNet.Mask) - 2 >= subNets[subNetCount].Hosts && Math.Pow(2, 32 - actNet.Mask - 1) - 2 < subNets[subNetCount].Hosts)
                    {
                        subNets[subNetCount].NetIP = actNet.NetIP;
                        subNets[subNetCount].Mask = actNet.Mask;
                        subNets[subNetCount].CalculateFirstIP();
                        subNets[subNetCount].CalculateBroadcast(octetsNum);
                        subNets[subNetCount].CalculateLastIP();
                        subNetCount++;
                        actNet = stackNets.Pop();
                    }
                    else
                    {
                        octetsNum = (int)Math.Ceiling((32 - (float)actNet.Mask) / 8);
                        string[] octets = actNet.NetIP.getBinaryRight(octetsNum);
                        string restBits = "";
                        for (int i = 0; i < (actNet.Mask % 8); i++)
                        {
                            restBits += octets[0][0];
                            octets[0] = octets[0].Remove(0, 1);
                        }

                        IP tempIP = actNet.NetIP.Clone();
                        for (int i = 0; i < octetsNum; i++)
                        {
                            if (i == 0)
                                tempIP.setBinaryOctet(i + (4 - octetsNum), restBits + octets[i]);
                            else
                                tempIP.setBinaryOctet(i + (4 - octetsNum), octets[i]);
                        }
                        Net first = new Net(tempIP.getIP(), actNet.Mask + 1, actNet.Level + 1);
                        for (int i = 0; i < octetsNum; i++)
                        {
                            if (i == 0)
                                tempIP.setBinaryOctet(i + (4 - octetsNum), restBits + '1' + octets[i].Substring(1));
                            else
                                tempIP.setBinaryOctet(i + (4 - octetsNum), octets[i]);
                        }
                        Net second = new Net(tempIP.getIP(), actNet.Mask + 1, actNet.Level + 1);
                        stackNets.Push(second);
                        actNet = first;
                    }
                }
            }
            foreach(SubNet subNet in subNets)
            {
                rboxProcess.Text += subNet.printSubNet() + "\n\n";
            }
        }

        private void appClose(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
