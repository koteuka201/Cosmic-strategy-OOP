namespace CosmStarategy
{
    partial class ExchangeTerminalWin
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
            this.buttonFuelBuy = new System.Windows.Forms.Button();
            this.buttonMetalBuy = new System.Windows.Forms.Button();
            this.buttonEnergyBuy = new System.Windows.Forms.Button();
            this.buttonEnergy = new System.Windows.Forms.Button();
            this.buttonFuel = new System.Windows.Forms.Button();
            this.buttonMetal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBarMetal = new System.Windows.Forms.ProgressBar();
            this.progressBarEnergy = new System.Windows.Forms.ProgressBar();
            this.progressBarFuel = new System.Windows.Forms.ProgressBar();
            this.eCapacity = new System.Windows.Forms.Label();
            this.mCapacity = new System.Windows.Forms.Label();
            this.fCapacity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonFuelBuy
            // 
            this.buttonFuelBuy.BackColor = System.Drawing.Color.Olive;
            this.buttonFuelBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFuelBuy.Location = new System.Drawing.Point(523, 560);
            this.buttonFuelBuy.Name = "buttonFuelBuy";
            this.buttonFuelBuy.Size = new System.Drawing.Size(120, 75);
            this.buttonFuelBuy.TabIndex = 1;
            this.buttonFuelBuy.Text = "Fuel";
            this.buttonFuelBuy.UseVisualStyleBackColor = false;
            this.buttonFuelBuy.Click += new System.EventHandler(this.buttonFuelBuy_Click);
            // 
            // buttonMetalBuy
            // 
            this.buttonMetalBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMetalBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMetalBuy.Location = new System.Drawing.Point(778, 560);
            this.buttonMetalBuy.Name = "buttonMetalBuy";
            this.buttonMetalBuy.Size = new System.Drawing.Size(120, 75);
            this.buttonMetalBuy.TabIndex = 3;
            this.buttonMetalBuy.Text = "Metal";
            this.buttonMetalBuy.UseVisualStyleBackColor = false;
            this.buttonMetalBuy.Click += new System.EventHandler(this.buttonMetalBuy_Click);
            // 
            // buttonEnergyBuy
            // 
            this.buttonEnergyBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonEnergyBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnergyBuy.Location = new System.Drawing.Point(260, 560);
            this.buttonEnergyBuy.Name = "buttonEnergyBuy";
            this.buttonEnergyBuy.Size = new System.Drawing.Size(120, 75);
            this.buttonEnergyBuy.TabIndex = 4;
            this.buttonEnergyBuy.Text = "Energy";
            this.buttonEnergyBuy.UseVisualStyleBackColor = false;
            this.buttonEnergyBuy.Click += new System.EventHandler(this.buttonEnergyBuy_Click);
            // 
            // buttonEnergy
            // 
            this.buttonEnergy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonEnergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnergy.Location = new System.Drawing.Point(260, 471);
            this.buttonEnergy.Name = "buttonEnergy";
            this.buttonEnergy.Size = new System.Drawing.Size(120, 40);
            this.buttonEnergy.TabIndex = 5;
            this.buttonEnergy.Text = "Energy";
            this.buttonEnergy.UseVisualStyleBackColor = false;
            this.buttonEnergy.Click += new System.EventHandler(this.buttonEnergy_Click);
            // 
            // buttonFuel
            // 
            this.buttonFuel.BackColor = System.Drawing.Color.Olive;
            this.buttonFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFuel.Location = new System.Drawing.Point(523, 471);
            this.buttonFuel.Name = "buttonFuel";
            this.buttonFuel.Size = new System.Drawing.Size(120, 40);
            this.buttonFuel.TabIndex = 6;
            this.buttonFuel.Text = "Fuel";
            this.buttonFuel.UseVisualStyleBackColor = false;
            this.buttonFuel.Click += new System.EventHandler(this.buttonFuel_Click);
            // 
            // buttonMetal
            // 
            this.buttonMetal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMetal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMetal.Location = new System.Drawing.Point(778, 471);
            this.buttonMetal.Name = "buttonMetal";
            this.buttonMetal.Size = new System.Drawing.Size(120, 40);
            this.buttonMetal.TabIndex = 7;
            this.buttonMetal.Text = "Metal";
            this.buttonMetal.UseVisualStyleBackColor = false;
            this.buttonMetal.Click += new System.EventHandler(this.buttonMetal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(450, 444);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Choose what you want to give:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(479, 533);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Choose what you want:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBarMetal
            // 
            this.progressBarMetal.Location = new System.Drawing.Point(12, 153);
            this.progressBarMetal.Name = "progressBarMetal";
            this.progressBarMetal.Size = new System.Drawing.Size(116, 28);
            this.progressBarMetal.TabIndex = 15;
            // 
            // progressBarEnergy
            // 
            this.progressBarEnergy.Location = new System.Drawing.Point(12, 95);
            this.progressBarEnergy.Name = "progressBarEnergy";
            this.progressBarEnergy.Size = new System.Drawing.Size(116, 28);
            this.progressBarEnergy.TabIndex = 14;
            // 
            // progressBarFuel
            // 
            this.progressBarFuel.Location = new System.Drawing.Point(12, 37);
            this.progressBarFuel.Name = "progressBarFuel";
            this.progressBarFuel.Size = new System.Drawing.Size(116, 28);
            this.progressBarFuel.TabIndex = 13;
            // 
            // eCapacity
            // 
            this.eCapacity.AutoSize = true;
            this.eCapacity.BackColor = System.Drawing.Color.Transparent;
            this.eCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eCapacity.ForeColor = System.Drawing.SystemColors.Control;
            this.eCapacity.Location = new System.Drawing.Point(8, 68);
            this.eCapacity.Name = "eCapacity";
            this.eCapacity.Size = new System.Drawing.Size(92, 24);
            this.eCapacity.TabIndex = 10;
            this.eCapacity.Text = "eCapacity";
            // 
            // mCapacity
            // 
            this.mCapacity.AutoSize = true;
            this.mCapacity.BackColor = System.Drawing.Color.Transparent;
            this.mCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mCapacity.ForeColor = System.Drawing.SystemColors.Control;
            this.mCapacity.Location = new System.Drawing.Point(8, 126);
            this.mCapacity.Name = "mCapacity";
            this.mCapacity.Size = new System.Drawing.Size(97, 24);
            this.mCapacity.TabIndex = 12;
            this.mCapacity.Text = "mCapacity";
            // 
            // fCapacity
            // 
            this.fCapacity.AutoSize = true;
            this.fCapacity.BackColor = System.Drawing.Color.Transparent;
            this.fCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fCapacity.ForeColor = System.Drawing.SystemColors.Control;
            this.fCapacity.Location = new System.Drawing.Point(8, 10);
            this.fCapacity.Name = "fCapacity";
            this.fCapacity.Size = new System.Drawing.Size(85, 24);
            this.fCapacity.TabIndex = 11;
            this.fCapacity.Text = "fCapacity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(875, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Rate of exchange 1:1";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(959, 434);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 34);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(886, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Defolt exchange 10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Lime;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(910, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "CONFIRM";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ExchangeTerminalWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CosmStarategy.Resource1.Terminal2;
            this.ClientSize = new System.Drawing.Size(1008, 647);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBarMetal);
            this.Controls.Add(this.progressBarEnergy);
            this.Controls.Add(this.progressBarFuel);
            this.Controls.Add(this.eCapacity);
            this.Controls.Add(this.mCapacity);
            this.Controls.Add(this.fCapacity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonMetal);
            this.Controls.Add(this.buttonFuel);
            this.Controls.Add(this.buttonEnergy);
            this.Controls.Add(this.buttonEnergyBuy);
            this.Controls.Add(this.buttonMetalBuy);
            this.Controls.Add(this.buttonFuelBuy);
            this.Name = "ExchangeTerminalWin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ExchangeTerminalWin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFuelBuy;
        private System.Windows.Forms.Button buttonMetalBuy;
        private System.Windows.Forms.Button buttonEnergyBuy;
        private System.Windows.Forms.Button buttonEnergy;
        private System.Windows.Forms.Button buttonFuel;
        private System.Windows.Forms.Button buttonMetal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBarMetal;
        private System.Windows.Forms.ProgressBar progressBarEnergy;
        private System.Windows.Forms.ProgressBar progressBarFuel;
        private System.Windows.Forms.Label eCapacity;
        private System.Windows.Forms.Label mCapacity;
        private System.Windows.Forms.Label fCapacity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}