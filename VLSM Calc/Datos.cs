using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VLSM_Calc
{
    public partial class Datos : Form
    {
        private static string[] maskValues = new string[] { "0", "128", "192", "224", "240", "248", "252", "254", "255" };
        private static int subNetCount = 1;

        public Datos()
        {
            InitializeComponent();
            txtName1.Text = "LAN" + subNetCount;
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
                    BorderStyle = plOriginal.BorderStyle
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
                            Location = control.Location
                        };
                    }
                    else if (control is TextBox && control.Name == "txtHosts1")
                    {
                        newControl = new TextBox()
                        {
                            Size = control.Size,
                            Location = control.Location
                        };
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
            else if (txt.Name == "txtHosts1" && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
