namespace CosmStarategy
{
    partial class SiriusCraft
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBackToMain = new System.Windows.Forms.Button();
            this.buttonCrait = new System.Windows.Forms.Button();
            this.progressBarMetal = new System.Windows.Forms.ProgressBar();
            this.progressBarEnergy = new System.Windows.Forms.ProgressBar();
            this.progressBarFuel = new System.Windows.Forms.ProgressBar();
            this.eCapacity = new System.Windows.Forms.Label();
            this.mCapacity = new System.Windows.Forms.Label();
            this.fCapacity = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonPandora = new System.Windows.Forms.Button();
            this.buttonKamino = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(418, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sirius";
            // 
            // buttonBackToMain
            // 
            this.buttonBackToMain.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBackToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBackToMain.Location = new System.Drawing.Point(10, 589);
            this.buttonBackToMain.Margin = new System.Windows.Forms.Padding(1);
            this.buttonBackToMain.Name = "buttonBackToMain";
            this.buttonBackToMain.Size = new System.Drawing.Size(77, 48);
            this.buttonBackToMain.TabIndex = 1;
            this.buttonBackToMain.Text = "Cosmic Space";
            this.buttonBackToMain.UseVisualStyleBackColor = false;
            this.buttonBackToMain.Click += new System.EventHandler(this.buttonBackToMain_Click_1);
            // 
            // buttonCrait
            // 
            this.buttonCrait.BackgroundImage = global::CosmStarategy.Resource1.crait;
            this.buttonCrait.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCrait.Location = new System.Drawing.Point(149, 383);
            this.buttonCrait.Name = "buttonCrait";
            this.buttonCrait.Size = new System.Drawing.Size(140, 140);
            this.buttonCrait.TabIndex = 2;
            this.buttonCrait.Text = "Crait";
            this.buttonCrait.UseVisualStyleBackColor = true;
            this.buttonCrait.Click += new System.EventHandler(this.buttonCrait_Click);
            // 
            // progressBarMetal
            // 
            this.progressBarMetal.Location = new System.Drawing.Point(16, 162);
            this.progressBarMetal.Name = "progressBarMetal";
            this.progressBarMetal.Size = new System.Drawing.Size(116, 28);
            this.progressBarMetal.TabIndex = 13;
            // 
            // progressBarEnergy
            // 
            this.progressBarEnergy.Location = new System.Drawing.Point(16, 104);
            this.progressBarEnergy.Name = "progressBarEnergy";
            this.progressBarEnergy.Size = new System.Drawing.Size(116, 28);
            this.progressBarEnergy.TabIndex = 12;
            // 
            // progressBarFuel
            // 
            this.progressBarFuel.Location = new System.Drawing.Point(16, 46);
            this.progressBarFuel.Name = "progressBarFuel";
            this.progressBarFuel.Size = new System.Drawing.Size(116, 28);
            this.progressBarFuel.TabIndex = 11;
            // 
            // eCapacity
            // 
            this.eCapacity.AutoSize = true;
            this.eCapacity.BackColor = System.Drawing.Color.Transparent;
            this.eCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eCapacity.ForeColor = System.Drawing.SystemColors.Control;
            this.eCapacity.Location = new System.Drawing.Point(12, 77);
            this.eCapacity.Name = "eCapacity";
            this.eCapacity.Size = new System.Drawing.Size(92, 24);
            this.eCapacity.TabIndex = 8;
            this.eCapacity.Text = "eCapacity";
            // 
            // mCapacity
            // 
            this.mCapacity.AutoSize = true;
            this.mCapacity.BackColor = System.Drawing.Color.Transparent;
            this.mCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mCapacity.ForeColor = System.Drawing.SystemColors.Control;
            this.mCapacity.Location = new System.Drawing.Point(12, 135);
            this.mCapacity.Name = "mCapacity";
            this.mCapacity.Size = new System.Drawing.Size(97, 24);
            this.mCapacity.TabIndex = 10;
            this.mCapacity.Text = "mCapacity";
            // 
            // fCapacity
            // 
            this.fCapacity.AutoSize = true;
            this.fCapacity.BackColor = System.Drawing.Color.Transparent;
            this.fCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fCapacity.ForeColor = System.Drawing.SystemColors.Control;
            this.fCapacity.Location = new System.Drawing.Point(12, 19);
            this.fCapacity.Name = "fCapacity";
            this.fCapacity.Size = new System.Drawing.Size(85, 24);
            this.fCapacity.TabIndex = 9;
            this.fCapacity.Text = "fCapacity";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonPandora
            // 
            this.buttonPandora.BackgroundImage = global::CosmStarategy.Resource1.Planet4;
            this.buttonPandora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPandora.Location = new System.Drawing.Point(348, 206);
            this.buttonPandora.Name = "buttonPandora";
            this.buttonPandora.Size = new System.Drawing.Size(90, 90);
            this.buttonPandora.TabIndex = 14;
            this.buttonPandora.Text = "Pandora";
            this.buttonPandora.UseVisualStyleBackColor = true;
            this.buttonPandora.Click += new System.EventHandler(this.buttonPandora_Click);
            // 
            // buttonKamino
            // 
            this.buttonKamino.BackgroundImage = global::CosmStarategy.Resource1.Planet5;
            this.buttonKamino.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonKamino.Location = new System.Drawing.Point(633, 60);
            this.buttonKamino.Name = "buttonKamino";
            this.buttonKamino.Size = new System.Drawing.Size(120, 120);
            this.buttonKamino.TabIndex = 15;
            this.buttonKamino.Text = "Kamino";
            this.buttonKamino.UseVisualStyleBackColor = true;
            this.buttonKamino.Click += new System.EventHandler(this.buttonKamino_Click);
            // 
            // SiriusCraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CosmStarategy.Resource1.siriusBack2;
            this.ClientSize = new System.Drawing.Size(1008, 647);
            this.Controls.Add(this.buttonKamino);
            this.Controls.Add(this.buttonPandora);
            this.Controls.Add(this.progressBarMetal);
            this.Controls.Add(this.progressBarEnergy);
            this.Controls.Add(this.progressBarFuel);
            this.Controls.Add(this.eCapacity);
            this.Controls.Add(this.mCapacity);
            this.Controls.Add(this.fCapacity);
            this.Controls.Add(this.buttonCrait);
            this.Controls.Add(this.buttonBackToMain);
            this.Controls.Add(this.label1);
            this.Name = "SiriusCraft";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.SiriusCraft_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.SiriusCraft_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBackToMain;
        private System.Windows.Forms.Button buttonCrait;
        private System.Windows.Forms.ProgressBar progressBarMetal;
        private System.Windows.Forms.ProgressBar progressBarEnergy;
        private System.Windows.Forms.ProgressBar progressBarFuel;
        private System.Windows.Forms.Label eCapacity;
        private System.Windows.Forms.Label mCapacity;
        private System.Windows.Forms.Label fCapacity;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonPandora;
        private System.Windows.Forms.Button buttonKamino;
    }
}