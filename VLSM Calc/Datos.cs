using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VLSM_Calc
{
    public partial class Datos : Form
    {
        private static string[] maskValues = new string[] { "0", "128", "192", "224", "240", "248", "252", "254", "255" };
        private static int subNetCount = 1;
        private static Form resultados;
        private static string netIP;

        public Datos()
        {
            InitializeComponent();
            txtName1.Text = "LAN" + subNetCount;
            txtIP.ValidatingType = typeof(System.Net.IPAddress);
        }

        private void numMask_ValueChanged(object sender, EventArgs e)
        {
            int octet = (int)numMask.Value / 8;
            int bits = (int)numMask.Value % 8;
            string mask = "";
            for (int i = 0; i < octet; i++)
            {
                mask += maskValues[8];
                if (i < 3)
                {
                    mask += ".";
                }
            }
            if (octet < 4)
            {
                mask += maskValues[bits];
                for (int i = octet + 1; i < 4; i++)
                {
                    mask += ".0";
                }
            }
            lblMask2.Text = mask;
        }

        private void btnAddSubNet_Click(object sender, EventArgs e)
        {
            int subnets = (int)numSubNets.Value;
            for (int i = 0; i < subnets; i++)
            {
                Panel row = new Panel()
                {
                    Size = plOriginal.Size,
                    Margin = plOriginal.Margin,
                    BorderStyle = plOriginal.BorderStyle,
                    Tag = "not-original"
                };

                foreach (Control control in plOriginal.Controls)
                {
                    Control newControl = null;
                    if (control is Label)
                    {
                        newControl = new Label()
                        {
                            Text = control.Text,
                            AutoSize = control.AutoSize,
                            Location = control.Location
                        };
                    }
                    else if (control is TextBox && control.Name == "txtName1")
                    {
                        newControl = new TextBox()
                        {
                            Size = control.Size,
                            Text = "LAN" + ++subNetCount,
                            Location = control.Location,
                            Tag = "name"
                        };
                    }
                    else if (control is TextBox && control.Name == "txtHosts1")
                    {
                        newControl = new TextBox()
                        {
                            Size = control.Size,
                            Location = control.Location,
                            Tag = "hosts"
                        };
                        newControl.KeyPress += CharControl;
                    }
                    else if (control is Button)
                    {
                        newControl = new Button()
                        {
                            Text = control.Text,
                            Size = control.Size,
                            Location = control.Location,
                            Dock = control.Dock,
                            BackColor = control.BackColor,
                            Tag = "not-first"
                        };
                        newControl.Click += delSubNet;
                    }
                    row.Controls.Add(newControl);
                }
                flowSubNets.Controls.Add(row);
            }
        }

        private void delSubNet(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Tag.Equals("first"))
            {
                txtName1.Text = "";
                txtHosts1.Text = "";
            }
            else
            {
                flowSubNets.Controls.Remove((Panel)btn.Parent);
            }
        }

        private void CharControl(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Name == "txtIP" && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            else if (txt.Tag == "hosts" && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (netIP != "")
            {
                int totalHosts = 0;
                bool valid = true;
                foreach (TextBox txt in flowSubNets.Controls.OfType<Panel>().SelectMany(panel => panel.Controls.OfType<TextBox>()))
                {
                    if (txt.Text == "")
                    {
                        valid = false;
                        break;
                    }
                    else if (txt.Tag.Equals("hosts"))
                    {
                        totalHosts += int.Parse(txt.Text);
                    }
                }
                if (valid)
                {
                    if (!(totalHosts > Math.Pow(2, 32 - (int)numMask.Value) - 2))
                    {
                        IP ip = new IP(netIP);
                        int hostBits = 32 - (int)numMask.Value;
                        float result = (float)hostBits / 8;
                        int octets = (int)Math.Ceiling(result);
                        string[] binaryOctects = ip.getBinaryRight(octets);
                        bool validIP = true;
                        int cont = 0;
                        for (int i = octets - 1; i >= 0; i--)
                        {
                            char[] tempChar = binaryOctects[i].ToCharArray();
                            for (int j = 7; j >= 0; j--)
                            {
                                cont++;
                                if (tempChar[j] == '1')
                                {
                                    validIP = false;
                                    break;
                                }
                                if (cont == hostBits)
                                {
                                    break;
                                }
                            }
                        }
                        if (validIP)
                        {
                            Net mainNet = new Net(ip, (int)numMask.Value, 0);
                            List<SubNet> subNets = new List<SubNet>();
                            List<TextBox> txtx = flowSubNets.Controls.OfType<Panel>().SelectMany(panel => panel.Controls.OfType<TextBox>()).ToList();
                            txtx.Count();
                            for (int i = 0; i < txtx.Count; i += 2)
                            {
                                subNets.Add(new SubNet(txtx[i + 1].Text, int.Parse(txtx[i].Text)));
                            }
                            resultados = new Resultados(mainNet, subNets, this);
                            resultados.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Dirección IP inválida, no es una IP de red.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El número total de hosts requeridos supera el límite de la red.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Todos los campos deben estar llenos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Dirección IP inválida, corrígela para continuar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtIP_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            MaskedTextBox box = (MaskedTextBox)sender;
            string cleanText = box.Text.Replace(" ", "");

            if (!System.Net.IPAddress.TryParse(cleanText, out _))
            {
                MessageBox.Show("Dirección IP inválida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                netIP = cleanText;
            }
        }


        private void txtIP_Enter(object sender, EventArgs e)
        {
            netIP = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (var panel in flowSubNets.Controls.OfType<Panel>().ToList())
            {
                if (panel.Name != "plOriginal")
                {
                    flowSubNets.Controls.Remove(panel);
                }
            }
            subNetCount = 1;
            txtName1.Text = "LAN" + subNetCount;
        }
    }
}
