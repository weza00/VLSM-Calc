namespace VLSM_Calc
{
    partial class Resultados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rboxProcess = new System.Windows.Forms.RichTextBox();
            this.dataAsigns = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.broadcastIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenPDF = new System.Windows.Forms.Button();
            this.savePDF = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataAsigns)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // rboxProcess
            // 
            this.rboxProcess.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rboxProcess.Location = new System.Drawing.Point(12, 103);
            this.rboxProcess.Name = "rboxProcess";
            this.rboxProcess.ReadOnly = true;
            this.rboxProcess.Size = new System.Drawing.Size(860, 274);
            this.rboxProcess.TabIndex = 0;
            this.rboxProcess.Text = "";
            // 
            // dataAsigns
            // 
            this.dataAsigns.AllowUserToAddRows = false;
            this.dataAsigns.AllowUserToDeleteRows = false;
            this.dataAsigns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAsigns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.netIP,
            this.mask,
            this.firstIP,
            this.lastIP,
            this.broadcastIP});
            this.dataAsigns.Location = new System.Drawing.Point(12, 383);
            this.dataAsigns.Name = "dataAsigns";
            this.dataAsigns.ReadOnly = true;
            this.dataAsigns.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataAsigns.Size = new System.Drawing.Size(733, 246);
            this.dataAsigns.TabIndex = 1;
            // 
            // name
            // 
            this.name.HeaderText = "Nombre";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 75;
            // 
            // netIP
            // 
            this.netIP.HeaderText = "IP de Red";
            this.netIP.Name = "netIP";
            this.netIP.ReadOnly = true;
            this.netIP.Width = 125;
            // 
            // mask
            // 
            this.mask.HeaderText = "Bits de Máscara";
            this.mask.Name = "mask";
            this.mask.ReadOnly = true;
            // 
            // firstIP
            // 
            this.firstIP.HeaderText = "Primera IP";
            this.firstIP.Name = "firstIP";
            this.firstIP.ReadOnly = true;
            this.firstIP.Width = 125;
            // 
            // lastIP
            // 
            this.lastIP.HeaderText = "Última IP";
            this.lastIP.Name = "lastIP";
            this.lastIP.ReadOnly = true;
            this.lastIP.Width = 125;
            // 
            // broadcastIP
            // 
            this.broadcastIP.HeaderText = "Broadcast";
            this.broadcastIP.Name = "broadcastIP";
            this.broadcastIP.ReadOnly = true;
            this.broadcastIP.Width = 125;
            // 
            // btnGenPDF
            // 
            this.btnGenPDF.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenPDF.Location = new System.Drawing.Point(0, 0);
            this.btnGenPDF.Name = "btnGenPDF";
            this.btnGenPDF.Size = new System.Drawing.Size(121, 123);
            this.btnGenPDF.TabIndex = 2;
            this.btnGenPDF.Text = "Generar PDF";
            this.btnGenPDF.UseVisualStyleBackColor = true;
            this.btnGenPDF.Click += new System.EventHandler(this.btnGenPDF_Click);
            // 
            // savePDF
            // 
            this.savePDF.FileName = "Resultado VLSM";
            this.savePDF.Filter = "Archivos PDF (*.pdf)|*.pdf";
            this.savePDF.Title = "Guardar PDF";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnGenPDF);
            this.panel1.Location = new System.Drawing.Point(751, 383);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 246);
            this.panel1.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBack.Location = new System.Drawing.Point(0, 123);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(121, 123);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Regresar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(91)))));
            this.panel2.Controls.Add(this.pboxLogo);
            this.panel2.Controls.Add(this.lblTitle2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 96);
            this.panel2.TabIndex = 4;
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.Color.White;
            this.lblTitle2.Location = new System.Drawing.Point(122, 19);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(284, 56);
            this.lblTitle2.TabIndex = 0;
            this.lblTitle2.Text = "Resultados";
            // 
            // pboxLogo
            // 
            this.pboxLogo.Image = global::VLSM_Calc.Properties.Resources.square_poll_horizontal_svgrepo_com;
            this.pboxLogo.Location = new System.Drawing.Point(24, 12);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(81, 77);
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxLogo.TabIndex = 1;
            this.pboxLogo.TabStop = false;
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(237)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(884, 641);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataAsigns);
            this.Controls.Add(this.rboxProcess);
            this.Font = new System.Drawing.Font("Consolas", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Resultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.appClose);
            ((System.ComponentModel.ISupportInitialize)(this.dataAsigns)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rboxProcess;
        private System.Windows.Forms.DataGridView dataAsigns;
        private System.Windows.Forms.Button btnGenPDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn netIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn mask;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastIP;
        private System.Windows.Forms.DataGridViewTextBoxColumn broadcastIP;
        private System.Windows.Forms.SaveFileDialog savePDF;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pboxLogo;
        private System.Windows.Forms.Label lblTitle2;
    }
}