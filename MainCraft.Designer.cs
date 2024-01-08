namespace CosmStarategy
{
    partial class MainCraft
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonSirius = new System.Windows.Forms.Button();
            this.buttonVega = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fCapacity = new System.Windows.Forms.Label();
            this.mCapacity = new System.Windows.Forms.Label();
            this.progressBarFuel = new System.Windows.Forms.ProgressBar();
            this.eCapacity = new System.Windows.Forms.Label();
            this.progressBarEnergy = new System.Windows.Forms.ProgressBar();
            this.progressBarMetal = new System.Windows.Forms.ProgressBar();
            this.energyTimer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonSirius
            // 
            this.buttonSirius.BackgroundImage = global::CosmStarategy.Resource1.sirius;
            this.buttonSirius.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSirius.Location = new System.Drawing.Point(186, 138);
            this.buttonSirius.Name = "buttonSirius";
            this.buttonSirius.Size = new System.Drawing.Size(180, 180);
            this.buttonSirius.TabIndex = 0;
            this.buttonSirius.Text = "Sirius";
            this.buttonSirius.UseVisualStyleBackColor = true;
            // 
            // buttonVega
            // 
            this.buttonVega.BackgroundImage = global::CosmStarategy.Resource1.vega2;
            this.buttonVega.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVega.Location = new System.Drawing.Point(666, 138);
            this.buttonVega.Name = "buttonVega";
            this.buttonVega.Size = new System.Drawing.Size(180, 180);
            this.buttonVega.TabIndex = 1;
            this.buttonVega.Text = "Vega";
            this.buttonVega.UseVisualStyleBackColor = true;
            this.buttonVega.Click += new System.EventHandler(this.buttonVega_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fCapacity
            // 
            this.fCapacity.AutoSize = true;
            this.fCapacity.BackColor = System.Drawing.Color.Transparent;
            this.fCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fCapacity.ForeColor = System.Drawing.SystemColors.Control;
            this.fCapacity.Location = new System.Drawing.Point(8, 22);
            this.fCapacity.Name = "fCapacity";
            this.fCapacity.Size = new System.Drawing.Size(85, 24);
            this.fCapacity.TabIndex = 3;
            this.fCapacity.Text = "fCapacity";
            // 
            // mCapacity
            // 
            this.mCapacity.AutoSize = true;
            this.mCapacity.BackColor = System.Drawing.Color.Transparent;
            this.mCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mCapacity.ForeColor = System.Drawing.SystemColors.Control;
            this.mCapacity.Location = new System.Drawing.Point(8, 138);
            this.mCapacity.Name = "mCapacity";
            this.mCapacity.Size = new System.Drawing.Size(97, 24);
            this.mCapacity.TabIndex = 4;
            this.mCapacity.Text = "mCapacity";
            // 
            // progressBarFuel
            // 
            this.progressBarFuel.Location = new System.Drawing.Point(12, 49);
            this.progressBarFuel.Name = "progressBarFuel";
            this.progressBarFuel.Size = new System.Drawing.Size(116, 28);
            this.progressBarFuel.TabIndex = 5;
            // 
            // eCapacity
            // 
            this.eCapacity.AutoSize = true;
            this.eCapacity.BackColor = System.Drawing.Color.Transparent;
            this.eCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eCapacity.ForeColor = System.Drawing.SystemColors.Control;
            this.eCapacity.Location = new System.Drawing.Point(8, 80);
            this.eCapacity.Name = "eCapacity";
            this.eCapacity.Size = new System.Drawing.Size(92, 24);
            this.eCapacity.TabIndex = 2;
            this.eCapacity.Text = "eCapacity";
            // 
            // progressBarEnergy
            // 
            this.progressBarEnergy.Location = new System.Drawing.Point(12, 107);
            this.progressBarEnergy.Name = "progressBarEnergy";
            this.progressBarEnergy.Size = new System.Drawing.Size(116, 28);
            this.progressBarEnergy.TabIndex = 6;
            // 
            // progressBarMetal
            // 
            this.progressBarMetal.Location = new System.Drawing.Point(12, 165);
            this.progressBarMetal.Name = "progressBarMetal";
            this.progressBarMetal.Size = new System.Drawing.Size(116, 28);
            this.progressBarMetal.TabIndex = 7;
            // 
            // energyTimer2
            // 
            this.energyTimer2.Enabled = true;
            this.energyTimer2.Interval = 2000;
            this.energyTimer2.Tick += new System.EventHandler(this.energyTimer2_Tick);
            // 
            // MainCraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CosmStarategy.Resource1.eK8W1PzfFi0;
            this.ClientSize = new System.Drawing.Size(1008, 647);
            this.Controls.Add(this.progressBarMetal);
            this.Controls.Add(this.progressBarEnergy);
            this.Controls.Add(this.progressBarFuel);
            this.Controls.Add(this.eCapacity);
            this.Controls.Add(this.mCapacity);
            this.Controls.Add(this.fCapacity);
            this.Controls.Add(this.buttonVega);
            this.Controls.Add(this.buttonSirius);
            this.Name = "MainCraft";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainCraft_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSirius;
        private System.Windows.Forms.Button buttonVega;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label fCapacity;
        private System.Windows.Forms.Label mCapacity;
        private System.Windows.Forms.ProgressBar progressBarFuel;
        private System.Windows.Forms.Label eCapacity;
        private System.Windows.Forms.ProgressBar progressBarEnergy;
        private System.Windows.Forms.ProgressBar progressBarMetal;
        private System.Windows.Forms.Timer energyTimer2;
    }
}

