﻿namespace CosmStarategy
{
    partial class TGU
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1005, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ТГУ — первый российский университет на территории Русской Азии, в Томске (фактиче" +
    "ски первый российский университет восточнее берегов Волги),";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TGU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CosmStarategy.Resource1.TGU;
            this.ClientSize = new System.Drawing.Size(1008, 647);
            this.Controls.Add(this.label1);
            this.Name = "TGU";
            this.Text = "TGU";
            this.Load += new System.EventHandler(this.TGU_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}