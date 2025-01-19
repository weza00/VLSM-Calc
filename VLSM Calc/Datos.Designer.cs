namespace VLSM_Calc
{
    partial class Datos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblMask = new System.Windows.Forms.Label();
            this.lblMask2 = new System.Windows.Forms.Label();
            this.gboxLans = new System.Windows.Forms.GroupBox();
            this.flowSubNets = new System.Windows.Forms.FlowLayoutPanel();
            this.plOriginal = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHosts1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDel1 = new System.Windows.Forms.Button();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.numMask = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddSubNet = new System.Windows.Forms.Button();
            this.numSubNets = new System.Windows.Forms.NumericUpDown();
            this.txtIP = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.gboxLans.SuspendLayout();
            this.flowSubNets.SuspendLayout();
            this.plOriginal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMask)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSubNets)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(88)))), ((int)(((byte)(91)))));
            this.panel1.Controls.Add(this.pboxLogo);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 96);
            this.panel1.TabIndex = 0;
            // 
            // pboxLogo
            // 
            this.pboxLogo.Image = global::VLSM_Calc.Properties.Resources.logo_vlsm;
            this.pboxLogo.Location = new System.Drawing.Point(24, 12);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(81, 77);
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxLogo.TabIndex = 1;
            this.pboxLogo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(122, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(440, 56);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Calculadora VLSM";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(17, 115);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(90, 19);
            this.lblIP.TabIndex = 1;
            this.lblIP.Text = "IP de Red";
            // 
            // lblMask
            // 
            this.lblMask.AutoSize = true;
            this.lblMask.Location = new System.Drawing.Point(264, 115);
            this.lblMask.Name = "lblMask";
            this.lblMask.Size = new System.Drawing.Size(18, 19);
            this.lblMask.TabIndex = 3;
            this.lblMask.Text = "/";
            // 
            // lblMask2
            // 
            this.lblMask2.AutoSize = true;
            this.lblMask2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMask2.Location = new System.Drawing.Point(260, 148);
            this.lblMask2.Name = "lblMask2";
            this.lblMask2.Size = new System.Drawing.Size(90, 19);
            this.lblMask2.TabIndex = 5;
            this.lblMask2.Text = "128.0.0.0";
            this.lblMask2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gboxLans
            // 
            this.gboxLans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gboxLans.Controls.Add(this.flowSubNets);
            this.gboxLans.Location = new System.Drawing.Point(12, 170);
            this.gboxLans.Name = "gboxLans";
            this.gboxLans.Size = new System.Drawing.Size(590, 295);
            this.gboxLans.TabIndex = 6;
            this.gboxLans.TabStop = false;
            this.gboxLans.Text = "Sub Redes";
            // 
            // flowSubNets
            // 
            this.flowSubNets.AutoScroll = true;
            this.flowSubNets.Controls.Add(this.plOriginal);
            this.flowSubNets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowSubNets.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowSubNets.Location = new System.Drawing.Point(3, 22);
            this.flowSubNets.Name = "flowSubNets";
            this.flowSubNets.Size = new System.Drawing.Size(584, 270);
            this.flowSubNets.TabIndex = 0;
            this.flowSubNets.WrapContents = false;
            // 
            // plOriginal
            // 
            this.plOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plOriginal.Controls.Add(this.label2);
            this.plOriginal.Controls.Add(this.txtHosts1);
            this.plOriginal.Controls.Add(this.label1);
            this.plOriginal.Controls.Add(this.btnDel1);
            this.plOriginal.Controls.Add(this.txtName1);
            this.plOriginal.Location = new System.Drawing.Point(3, 3);
            this.plOriginal.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.plOriginal.Name = "plOriginal";
            this.plOriginal.Size = new System.Drawing.Size(561, 68);
            this.plOriginal.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hosts";
            // 
            // txtHosts1
            // 
            this.txtHosts1.Location = new System.Drawing.Point(251, 28);
            this.txtHosts1.Name = "txtHosts1";
            this.txtHosts1.Size = new System.Drawing.Size(100, 26);
            this.txtHosts1.TabIndex = 4;
            this.txtHosts1.Tag = "hosts";
            this.txtHosts1.Text = "5000";
            this.txtHosts1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CharControl);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // btnDel1
            // 
            this.btnDel1.BackColor = System.Drawing.Color.White;
            this.btnDel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDel1.Location = new System.Drawing.Point(410, 0);
            this.btnDel1.Name = "btnDel1";
            this.btnDel1.Size = new System.Drawing.Size(149, 66);
            this.btnDel1.TabIndex = 2;
            this.btnDel1.Tag = "first";
            this.btnDel1.Text = "Eliminar";
            this.btnDel1.UseVisualStyleBackColor = false;
            this.btnDel1.Click += new System.EventHandler(this.delSubNet);
            // 
            // txtName1
            // 
            this.txtName1.Location = new System.Drawing.Point(75, 28);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(100, 26);
            this.txtName1.TabIndex = 0;
            this.txtName1.Tag = "name";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCalculate.Location = new System.Drawing.Point(616, 96);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(110, 381);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // numMask
            // 
            this.numMask.Location = new System.Drawing.Point(286, 113);
            this.numMask.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numMask.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMask.Name = "numMask";
            this.numMask.Size = new System.Drawing.Size(43, 26);
            this.numMask.TabIndex = 8;
            this.numMask.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.numMask.ValueChanged += new System.EventHandler(this.numMask_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnAddSubNet);
            this.panel2.Controls.Add(this.numSubNets);
            this.panel2.Location = new System.Drawing.Point(435, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 55);
            this.panel2.TabIndex = 9;
            // 
            // btnAddSubNet
            // 
            this.btnAddSubNet.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddSubNet.Location = new System.Drawing.Point(64, 0);
            this.btnAddSubNet.Name = "btnAddSubNet";
            this.btnAddSubNet.Size = new System.Drawing.Size(101, 53);
            this.btnAddSubNet.TabIndex = 1;
            this.btnAddSubNet.Text = "Agregar Subred/es";
            this.btnAddSubNet.UseVisualStyleBackColor = true;
            this.btnAddSubNet.Click += new System.EventHandler(this.btnAddSubNet_Click);
            // 
            // numSubNets
            // 
            this.numSubNets.Location = new System.Drawing.Point(10, 13);
            this.numSubNets.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSubNets.Name = "numSubNets";
            this.numSubNets.Size = new System.Drawing.Size(48, 26);
            this.numSubNets.TabIndex = 0;
            this.numSubNets.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(113, 112);
            this.txtIP.Mask = "###,###,###,###";
            this.txtIP.Name = "txtIP";
            this.txtIP.PromptChar = ' ';
            this.txtIP.Size = new System.Drawing.Size(145, 26);
            this.txtIP.TabIndex = 10;
            this.txtIP.Text = "17217 128 0";
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIP.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.txtIP_TypeValidationCompleted);
            this.txtIP.Enter += new System.EventHandler(this.txtIP_Enter);
            // 
            // Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(237)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(726, 477);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.numMask);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.gboxLans);
            this.Controls.Add(this.lblMask2);
            this.Controls.Add(this.lblMask);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Datos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VLSM Calc";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            this.gboxLans.ResumeLayout(false);
            this.flowSubNets.ResumeLayout(false);
            this.plOriginal.ResumeLayout(false);
            this.plOriginal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMask)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSubNets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pboxLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblMask;
        private System.Windows.Forms.Label lblMask2;
        private System.Windows.Forms.GroupBox gboxLans;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.NumericUpDown numMask;
        private System.Windows.Forms.FlowLayoutPanel flowSubNets;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddSubNet;
        private System.Windows.Forms.NumericUpDown numSubNets;
        private System.Windows.Forms.Panel plOriginal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHosts1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDel1;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.MaskedTextBox txtIP;
    }
}

