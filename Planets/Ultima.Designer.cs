namespace CosmStarategy
{
    partial class Ultima
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
            this.components = new System.ComponentModel.Container();
            this.progressBarMetal = new System.Windows.Forms.ProgressBar();
            this.progressBarEnergy = new System.Windows.Forms.ProgressBar();
            this.progressBarFuel = new System.Windows.Forms.ProgressBar();
            this.eCapacity = new System.Windows.Forms.Label();
            this.mCapacity = new System.Windows.Forms.Label();
            this.fCapacity = new System.Windows.Forms.Label();
            this.buttonBuildings = new System.Windows.Forms.Button();
            this.buttonBackToPlanets = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progressBarMetal
            // 
            this.progressBarMetal.Location = new System.Drawing.Point(16, 155);
            this.progressBarMetal.Name = "progressBarMetal";
            this.progressBarMetal.Size = new System.Drawing.Size(116, 28);
            this.progressBarMetal.TabIndex = 27;
            // 
            // progressBarEnergy
            // 
            this.progressBarEnergy.Location = new System.Drawing.Point(16, 97);
            this.progressBarEnergy.Name = "progressBarEnergy";
            this.progressBarEnergy.Size = new System.Drawing.Size(116, 28);
            this.progressBarEnergy.TabIndex = 26;
            // 
            // progressBarFuel
            // 
            this.progressBarFuel.Location = new System.Drawing.Point(16, 39);
            this.progressBarFuel.Name = "progressBarFuel";
            this.progressBarFuel.Size = new System.Drawing.Size(116, 28);
            this.progressBarFuel.TabIndex = 25;
            // 
            // eCapacity
            // 
            this.eCapacity.AutoSize = true;
            this.eCapacity.BackColor = System.Drawing.Color.Transparent;
            this.eCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eCapacity.ForeColor = System.Drawing.SystemColors.Control;
            this.eCapacity.Location = new System.Drawing.Point(12, 70);
            this.eCapacity.Name = "eCapacity";
            this.eCapacity.Size = new System.Drawing.Size(92, 24);
            this.eCapacity.TabIndex = 22;
            this.eCapacity.Text = "eCapacity";
            // 
            // mCapacity
            // 
            this.mCapacity.AutoSize = true;
            this.mCapacity.BackColor = System.Drawing.Color.Transparent;
            this.mCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mCapacity.ForeColor = System.Drawing.SystemColors.Control;
            this.mCapacity.Location = new System.Drawing.Point(12, 128);
            this.mCapacity.Name = "mCapacity";
            this.mCapacity.Size = new System.Drawing.Size(97, 24);
            this.mCapacity.TabIndex = 24;
            this.mCapacity.Text = "mCapacity";
            // 
            // fCapacity
            // 
            this.fCapacity.AutoSize = true;
            this.fCapacity.BackColor = System.Drawing.Color.Transparent;
            this.fCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fCapacity.ForeColor = System.Drawing.SystemColors.Control;
            this.fCapacity.Location = new System.Drawing.Point(12, 12);
            this.fCapacity.Name = "fCapacity";
            this.fCapacity.Size = new System.Drawing.Size(85, 24);
            this.fCapacity.TabIndex = 23;
            this.fCapacity.Text = "fCapacity";
            // 
            // buttonBuildings
            // 
            this.buttonBuildings.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBuildings.Location = new System.Drawing.Point(419, 155);
            this.buttonBuildings.Name = "buttonBuildings";
            this.buttonBuildings.Size = new System.Drawing.Size(200, 200);
            this.buttonBuildings.TabIndex = 28;
            this.buttonBuildings.Text = "Buildings";
            this.buttonBuildings.UseVisualStyleBackColor = true;
            this.buttonBuildings.Click += new System.EventHandler(this.buttonBuildings_Click);
            // 
            // buttonBackToPlanets
            // 
            this.buttonBackToPlanets.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBackToPlanets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBackToPlanets.Location = new System.Drawing.Point(10, 589);
            this.buttonBackToPlanets.Margin = new System.Windows.Forms.Padding(1);
            this.buttonBackToPlanets.Name = "buttonBackToPlanets";
            this.buttonBackToPlanets.Size = new System.Drawing.Size(77, 48);
            this.buttonBackToPlanets.TabIndex = 29;
            this.buttonBackToPlanets.Text = "Planets";
            this.buttonBackToPlanets.UseVisualStyleBackColor = false;
            this.buttonBackToPlanets.Click += new System.EventHandler(this.buttonBackToPlanets_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Ultima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CosmStarategy.Resource1.CraitBack;
            this.ClientSize = new System.Drawing.Size(1008, 647);
            this.Controls.Add(this.buttonBackToPlanets);
            this.Controls.Add(this.buttonBuildings);
            this.Controls.Add(this.progressBarMetal);
            this.Controls.Add(this.progressBarEnergy);
            this.Controls.Add(this.progressBarFuel);
            this.Controls.Add(this.eCapacity);
            this.Controls.Add(this.mCapacity);
            this.Controls.Add(this.fCapacity);
            this.Name = "Ultima";
            this.Text = "Ultima";
            this.Load += new System.EventHandler(this.Ultima_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Ultima_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarMetal;
        private System.Windows.Forms.ProgressBar progressBarEnergy;
        private System.Windows.Forms.ProgressBar progressBarFuel;
        private System.Windows.Forms.Label eCapacity;
        private System.Windows.Forms.Label mCapacity;
        private System.Windows.Forms.Label fCapacity;
        private System.Windows.Forms.Button buttonBuildings;
        private System.Windows.Forms.Button buttonBackToPlanets;
        private System.Windows.Forms.Timer timer1;
    }
}