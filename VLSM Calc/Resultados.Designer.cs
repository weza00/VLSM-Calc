﻿namespace VLSM_Calc
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
            this.SuspendLayout();
            // 
            // rboxProcess
            // 
            this.rboxProcess.Dock = System.Windows.Forms.DockStyle.Top;
            this.rboxProcess.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rboxProcess.Location = new System.Drawing.Point(0, 0);
            this.rboxProcess.Name = "rboxProcess";
            this.rboxProcess.ReadOnly = true;
            this.rboxProcess.Size = new System.Drawing.Size(884, 368);
            this.rboxProcess.TabIndex = 0;
            this.rboxProcess.Text = "";
            // 
            // Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.rboxProcess);
            this.Font = new System.Drawing.Font("Consolas", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Resultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.appClose);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rboxProcess;
    }
}