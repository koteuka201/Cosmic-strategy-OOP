namespace CosmStarategy
{
    partial class Miner
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
            this.buttonCollectMetal = new System.Windows.Forms.Button();
            this.progressBarMetal = new System.Windows.Forms.ProgressBar();
            this.progressBarEnergy = new System.Windows.Forms.ProgressBar();
            this.progressBarFuel = new System.Windows.Forms.ProgressBar();
            this.eCapacity = new System.Windows.Forms.Label();
            this.mCapacity = new System.Windows.Forms.Label();
            this.fCapacity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCollectMetal
            // 
            this.buttonCollectMetal.BackColor = System.Drawing.Color.Silver;
            this.buttonCollectMetal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCollectMetal.Location = new System.Drawing.Point(863, 518);
            this.buttonCollectMetal.Name = "buttonCollectMetal";
            this.buttonCollectMetal.Size = new System.Drawing.Size(100, 100);
            this.buttonCollectMetal.TabIndex = 1;
            this.buttonCollectMetal.Text = "Collect Metal";
            this.buttonCollectMetal.UseVisualStyleBackColor = false;
            this.buttonCollectMetal.Click += new System.EventHandler(this.buttonCollectMetal_Click);
            // 
            // progressBarMetal
            // 
            this.progressBarMetal.Location = new System.Drawing.Point(12, 156);
            this.progressBarMetal.Name = "progressBarMetal";
            this.progressBarMetal.Size = new System.Drawing.Size(116, 28);
            this.progressBarMetal.TabIndex = 31;
            // 
            // progressBarEnergy
            // 
            this.progressBarEnergy.Location = new System.Drawing.Point(12, 98);
            this.progressBarEnergy.Name = "progressBarEnergy";
            this.progressBarEnergy.Size = new System.Drawing.Size(116, 28);
            this.progressBarEnergy.TabIndex = 30;
            // 
            // progressBarFuel
            // 
            this.progressBarFuel.Location = new System.Drawing.Point(12, 40);
            this.progressBarFuel.Name = "progressBarFuel";
            this.progressBarFuel.Size = new System.Drawing.Size(116, 28);
            this.progressBarFuel.TabIndex = 29;
            // 
            // eCapacity
            // 
            this.eCapacity.AutoSize = true;
            this.eCapacity.BackColor = System.Drawing.Color.Transparent;
            this.eCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eCapacity.ForeColor = System.Drawing.SystemColors.Control;
            this.eCapacity.Location = new System.Drawing.Point(8, 71);
            this.eCapacity.Name = "eCapacity";
            this.eCapacity.Size = new System.Drawing.Size(92, 24);
            this.eCapacity.TabIndex = 26;
            this.eCapacity.Text = "eCapacity";
            // 
            // mCapacity
            // 
            this.mCapacity.AutoSize = true;
            this.mCapacity.BackColor = System.Drawing.Color.Transparent;
            this.mCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mCapacity.ForeColor = System.Drawing.SystemColors.Control;
            this.mCapacity.Location = new System.Drawing.Point(8, 129);
            this.mCapacity.Name = "mCapacity";
            this.mCapacity.Size = new System.Drawing.Size(97, 24);
            this.mCapacity.TabIndex = 28;
            this.mCapacity.Text = "mCapacity";
            // 
            // fCapacity
            // 
            this.fCapacity.AutoSize = true;
            this.fCapacity.BackColor = System.Drawing.Color.Transparent;
            this.fCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fCapacity.ForeColor = System.Drawing.SystemColors.Control;
            this.fCapacity.Location = new System.Drawing.Point(8, 13);
            this.fCapacity.Name = "fCapacity";
            this.fCapacity.Size = new System.Drawing.Size(85, 24);
            this.fCapacity.TabIndex = 27;
            this.fCapacity.Text = "fCapacity";
            // 
            // Miner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CosmStarategy.Resource1.shahta;
            this.ClientSize = new System.Drawing.Size(1008, 647);
            this.Controls.Add(this.progressBarMetal);
            this.Controls.Add(this.progressBarEnergy);
            this.Controls.Add(this.progressBarFuel);
            this.Controls.Add(this.eCapacity);
            this.Controls.Add(this.mCapacity);
            this.Controls.Add(this.fCapacity);
            this.Controls.Add(this.buttonCollectMetal);
            this.Name = "Miner";
            this.Text = "Miner";
            this.Load += new System.EventHandler(this.Miner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCollectMetal;
        private System.Windows.Forms.ProgressBar progressBarMetal;
        private System.Windows.Forms.ProgressBar progressBarEnergy;
        private System.Windows.Forms.ProgressBar progressBarFuel;
        private System.Windows.Forms.Label eCapacity;
        private System.Windows.Forms.Label mCapacity;
        private System.Windows.Forms.Label fCapacity;
    }
}