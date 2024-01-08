namespace CosmStarategy
{
    partial class VegaCraft
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
            this.buttonBackToMain = new System.Windows.Forms.Button();
            this.buttonUltima = new System.Windows.Forms.Button();
            this.buttonVectra = new System.Windows.Forms.Button();
            this.buttonAiris = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progressBarMetal
            // 
            this.progressBarMetal.Location = new System.Drawing.Point(12, 162);
            this.progressBarMetal.Name = "progressBarMetal";
            this.progressBarMetal.Size = new System.Drawing.Size(116, 28);
            this.progressBarMetal.TabIndex = 20;
            // 
            // progressBarEnergy
            // 
            this.progressBarEnergy.Location = new System.Drawing.Point(12, 104);
            this.progressBarEnergy.Name = "progressBarEnergy";
            this.progressBarEnergy.Size = new System.Drawing.Size(116, 28);
            this.progressBarEnergy.TabIndex = 19;
            // 
            // progressBarFuel
            // 
            this.progressBarFuel.Location = new System.Drawing.Point(12, 46);
            this.progressBarFuel.Name = "progressBarFuel";
            this.progressBarFuel.Size = new System.Drawing.Size(116, 28);
            this.progressBarFuel.TabIndex = 18;
            // 
            // eCapacity
            // 
            this.eCapacity.AutoSize = true;
            this.eCapacity.BackColor = System.Drawing.Color.Transparent;
            this.eCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eCapacity.ForeColor = System.Drawing.SystemColors.Control;
            this.eCapacity.Location = new System.Drawing.Point(8, 77);
            this.eCapacity.Name = "eCapacity";
            this.eCapacity.Size = new System.Drawing.Size(92, 24);
            this.eCapacity.TabIndex = 15;
            this.eCapacity.Text = "eCapacity";
            // 
            // mCapacity
            // 
            this.mCapacity.AutoSize = true;
            this.mCapacity.BackColor = System.Drawing.Color.Transparent;
            this.mCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mCapacity.ForeColor = System.Drawing.SystemColors.Control;
            this.mCapacity.Location = new System.Drawing.Point(8, 135);
            this.mCapacity.Name = "mCapacity";
            this.mCapacity.Size = new System.Drawing.Size(97, 24);
            this.mCapacity.TabIndex = 17;
            this.mCapacity.Text = "mCapacity";
            // 
            // fCapacity
            // 
            this.fCapacity.AutoSize = true;
            this.fCapacity.BackColor = System.Drawing.Color.Transparent;
            this.fCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fCapacity.ForeColor = System.Drawing.SystemColors.Control;
            this.fCapacity.Location = new System.Drawing.Point(8, 19);
            this.fCapacity.Name = "fCapacity";
            this.fCapacity.Size = new System.Drawing.Size(85, 24);
            this.fCapacity.TabIndex = 16;
            this.fCapacity.Text = "fCapacity";
            // 
            // buttonBackToMain
            // 
            this.buttonBackToMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBackToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBackToMain.Location = new System.Drawing.Point(6, 589);
            this.buttonBackToMain.Margin = new System.Windows.Forms.Padding(1);
            this.buttonBackToMain.Name = "buttonBackToMain";
            this.buttonBackToMain.Size = new System.Drawing.Size(77, 48);
            this.buttonBackToMain.TabIndex = 14;
            this.buttonBackToMain.Text = "Cosmic Space";
            this.buttonBackToMain.UseVisualStyleBackColor = false;
            this.buttonBackToMain.Click += new System.EventHandler(this.buttonBackToMain_Click);
            // 
            // buttonUltima
            // 
            this.buttonUltima.BackgroundImage = global::CosmStarategy.Resource1.Planet6;
            this.buttonUltima.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUltima.Location = new System.Drawing.Point(641, 135);
            this.buttonUltima.Name = "buttonUltima";
            this.buttonUltima.Size = new System.Drawing.Size(130, 130);
            this.buttonUltima.TabIndex = 22;
            this.buttonUltima.Text = "Ultima";
            this.buttonUltima.UseVisualStyleBackColor = true;
            this.buttonUltima.Click += new System.EventHandler(this.buttonUltima_Click);
            // 
            // buttonVectra
            // 
            this.buttonVectra.BackgroundImage = global::CosmStarategy.Resource1.Planet3;
            this.buttonVectra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVectra.Location = new System.Drawing.Point(302, 162);
            this.buttonVectra.Name = "buttonVectra";
            this.buttonVectra.Size = new System.Drawing.Size(180, 180);
            this.buttonVectra.TabIndex = 23;
            this.buttonVectra.Text = "Vectra";
            this.buttonVectra.UseVisualStyleBackColor = true;
            this.buttonVectra.Click += new System.EventHandler(this.buttonVectra_Click);
            // 
            // buttonAiris
            // 
            this.buttonAiris.BackgroundImage = global::CosmStarategy.Resource1.Planet2;
            this.buttonAiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAiris.Location = new System.Drawing.Point(160, 394);
            this.buttonAiris.Name = "buttonAiris";
            this.buttonAiris.Size = new System.Drawing.Size(111, 111);
            this.buttonAiris.TabIndex = 24;
            this.buttonAiris.Text = "Airis";
            this.buttonAiris.UseVisualStyleBackColor = true;
            this.buttonAiris.Click += new System.EventHandler(this.buttonAiris_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // VegaCraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CosmStarategy.Resource1.vegacr;
            this.ClientSize = new System.Drawing.Size(933, 647);
            this.Controls.Add(this.buttonAiris);
            this.Controls.Add(this.buttonVectra);
            this.Controls.Add(this.buttonUltima);
            this.Controls.Add(this.progressBarMetal);
            this.Controls.Add(this.progressBarEnergy);
            this.Controls.Add(this.progressBarFuel);
            this.Controls.Add(this.eCapacity);
            this.Controls.Add(this.mCapacity);
            this.Controls.Add(this.fCapacity);
            this.Controls.Add(this.buttonBackToMain);
            this.Name = "VegaCraft";
            this.Text = "VegaCraft";
            this.Load += new System.EventHandler(this.VegaCraft_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.VegaCraft_Paint);
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
        private System.Windows.Forms.Button buttonBackToMain;
        private System.Windows.Forms.Button buttonUltima;
        private System.Windows.Forms.Button buttonVectra;
        private System.Windows.Forms.Button buttonAiris;
        private System.Windows.Forms.Timer timer1;
    }
}