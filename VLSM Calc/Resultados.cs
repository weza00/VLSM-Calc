using PdfSharp;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace VLSM_Calc
{
    public partial class Resultados : Form
    {
        private Net mainNet;
        private List<SubNet> subNets;
        private Form datos;

        public Resultados(Net mainNet, List<SubNet> subNets, Datos datos)
        {
            InitializeComponent();
            this.mainNet = mainNet;
            this.subNets = subNets;
            this.subNets = this.subNets.OrderByDescending(x => x.Hosts).ToList();
            this.datos = datos;
            VLSM();
            DataShow();
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
                    rboxProcess.AppendText(actNet.getNet((int)Math.Ceiling((32 - (float)mainNet.Mask) / 8)) + "\n");
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
                        rboxProcess.SelectionColor = Color.Green;
                        rboxProcess.AppendText(actNet.getNet((int)Math.Ceiling((32 - (float)mainNet.Mask) / 8)) + " <- " + subNets[subNetCount].Name + "\n");
                        rboxProcess.SelectionColor = Color.Black;
                        subNetCount++;
                        if (subNetCount != subNets.Count)
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
                        rboxProcess.AppendText(actNet.getNet((int)Math.Ceiling((32 - (float)mainNet.Mask) / 8)) + "\n");
                        actNet = first;
                    }
                }
            }
            while (stackNets.Count > 0)
            {
                rboxProcess.AppendText(stackNets.Pop().getNet((int)Math.Ceiling((32 - (float)mainNet.Mask) / 8)) + "\n");
            }
        }

        private void DataShow()
        {
            foreach (SubNet subNet in subNets)
            {
                dataAsigns.Rows.Add(subNet.Name, subNet.NetIP.getIP(), subNet.Mask, subNet.FirstIP.getIP(), subNet.LastIP.getIP(), subNet.Broadcast.getIP());
            }
        }

        private void btnGenPDF_Click(object sender, EventArgs e)
        {
            if (savePDF.ShowDialog() == DialogResult.OK)
            {
                string path = savePDF.FileName;
                try
                {
                    PdfDocument document = new PdfDocument();
                    PdfPage page = document.AddPage();
                    page.Orientation = PageOrientation.Landscape;
                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    XFont titleFont = new XFont("Courier New", 14, XFontStyleEx.Bold);
                    XFont headerFont = new XFont("Courier New", 12, XFontStyleEx.Bold);
                    XFont rowFont = new XFont("Courier New", 8, XFontStyleEx.Regular);
                    gfx.DrawString("VLSM CALC", titleFont, XBrushes.Black, new XRect(0, 0, page.Width, page.Height), XStringFormats.TopCenter);

                    string[] processLines = rboxProcess.Lines;
                    float yPoint = 40;
                    foreach (string line in processLines)
                    {
                        if (yPoint > page.Height - 40)
                        {
                            page = document.AddPage();
                            page.Orientation = PageOrientation.Landscape;
                            gfx = XGraphics.FromPdfPage(page);
                            yPoint = 40;
                        }
                        gfx.DrawString(line.Replace("\t", "    "), titleFont, XBrushes.Black, new XRect(20, yPoint, page.Width - 40, page.Height), XStringFormats.TopLeft);
                        yPoint += 20;
                    }

                    yPoint += 20;
                    string[] headers = { "Nombre", "IP Red", "Máscara", "Primera IP", "Última IP", "Broadcast" };
                    float[] columnWidths = { 100, 100, 50, 100, 100, 100 };
                    float xPoint = 20;
                    for (int i = 0; i < headers.Length; i++)
                    {
                        if (yPoint > page.Height - 40)
                        {
                            page = document.AddPage();
                            page.Orientation = PageOrientation.Landscape;
                            gfx = XGraphics.FromPdfPage(page);
                            yPoint = 40;
                        }
                        gfx.DrawString(headers[i], headerFont, XBrushes.Black, new XRect(xPoint, yPoint, columnWidths[i], 20), XStringFormats.TopLeft);
                        gfx.DrawRectangle(XPens.Black, xPoint, yPoint, columnWidths[i], 20);
                        xPoint += columnWidths[i];
                    }

                    yPoint += 20;
                    foreach (DataGridViewRow row in dataAsigns.Rows)
                    {
                        if (row.IsNewRow) continue;
                        xPoint = 20;
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            if (yPoint > page.Height - 40)
                            {
                                page = document.AddPage();
                                page.Orientation = PageOrientation.Landscape;
                                gfx = XGraphics.FromPdfPage(page);
                                yPoint = 40;
                            }
                            gfx.DrawString(row.Cells[i].Value?.ToString() ?? string.Empty, rowFont, XBrushes.Black, new XRect(xPoint, yPoint, columnWidths[i], 20), XStringFormats.TopLeft);
                            gfx.DrawRectangle(XPens.Black, xPoint, yPoint, columnWidths[i], 20);
                            xPoint += columnWidths[i];
                        }
                        yPoint += 20;
                    }

                    document.Save(path);
                    MessageBox.Show("PDF generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar el PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            rboxProcess.Clear();
            dataAsigns.Rows.Clear();
            datos.Show();
            this.Close();
        }

        private void appClose(object sender, FormClosingEventArgs e)
        {
            if (!datos.Visible)
            {
                Application.Exit();
            }
        }
    }
}
