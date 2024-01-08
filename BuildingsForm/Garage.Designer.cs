namespace CosmStarategy
{
    partial class Garage
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
            this.buttonUpgradeEngine = new System.Windows.Forms.Button();
            this.buttonUpgradeFuelTank = new System.Windows.Forms.Button();
            this.buttonUpgradeBattery = new System.Windows.Forms.Button();
            this.labelCostFuelTankUpgrade = new System.Windows.Forms.Label();
            this.labelCostEngineUpgrade = new System.Windows.Forms.Label();
            this.labelCostBatteryUpgrade = new System.Windows.Forms.Label();
            this.Notice = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelCostMetalStorageUpgrade = new System.Windows.Forms.Label();
            this.buttonUpgradeMetalStorage = new System.Windows.Forms.Button();
            this.progressBarMetal = new System.Windows.Forms.ProgressBar();
            this.progressBarEnergy = new System.Windows.Forms.ProgressBar();
            this.progressBarFuel = new System.Windows.Forms.ProgressBar();
            this.eCapacity = new System.Windows.Forms.Label();
            this.mCapacity = new System.Windows.Forms.Label();
            this.fCapacity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(456, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Garage";
            // 
            // buttonUpgradeEngine
            // 
            this.buttonUpgradeEngine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonUpgradeEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpgradeEngine.Location = new System.Drawing.Point(195, 393);
            this.buttonUpgradeEngine.Name = "buttonUpgradeEngine";
            this.buttonUpgradeEngine.Size = new System.Drawing.Size(200, 200);
            this.buttonUpgradeEngine.TabIndex = 1;
            this.buttonUpgradeEngine.Text = "Upgrade Engine";
            this.buttonUpgradeEngine.UseVisualStyleBackColor = false;
            this.buttonUpgradeEngine.Click += new System.EventHandler(this.buttonUpgradeEngine_Click);
            // 
            // buttonUpgradeFuelTank
            // 
            this.buttonUpgradeFuelTank.BackColor = System.Drawing.Color.Olive;
            this.buttonUpgradeFuelTank.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpgradeFuelTank.Location = new System.Drawing.Point(195, 136);
            this.buttonUpgradeFuelTank.Name = "buttonUpgradeFuelTank";
            this.buttonUpgradeFuelTank.Size = new System.Drawing.Size(200, 200);
            this.buttonUpgradeFuelTank.TabIndex = 2;
            this.buttonUpgradeFuelTank.Text = "Upgrade Fuel Tank";
            this.buttonUpgradeFuelTank.UseVisualStyleBackColor = false;
            this.buttonUpgradeFuelTank.Click += new System.EventHandler(this.buttonUpgradeFuelTank_Click);
            // 
            // buttonUpgradeBattery
            // 
            this.buttonUpgradeBattery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonUpgradeBattery.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpgradeBattery.Location = new System.Drawing.Point(639, 393);
            this.buttonUpgradeBattery.Name = "buttonUpgradeBattery";
            this.buttonUpgradeBattery.Size = new System.Drawing.Size(200, 200);
            this.buttonUpgradeBattery.TabIndex = 3;
            this.buttonUpgradeBattery.Text = "Upgrade Battery";
            this.buttonUpgradeBattery.UseVisualStyleBackColor = false;
            this.buttonUpgradeBattery.Click += new System.EventHandler(this.buttonUpgradeBattery_Click);
            // 
            // labelCostFuelTankUpgrade
            // 
            this.labelCostFuelTankUpgrade.AutoSize = true;
            this.labelCostFuelTankUpgrade.BackColor = System.Drawing.Color.Transparent;
            this.labelCostFuelTankUpgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCostFuelTankUpgrade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCostFuelTankUpgrade.Location = new System.Drawing.Point(190, 108);
            this.labelCostFuelTankUpgrade.Name = "labelCostFuelTankUpgrade";
            this.labelCostFuelTankUpgrade.Size = new System.Drawing.Size(150, 25);
            this.labelCostFuelTankUpgrade.TabIndex = 4;
            this.labelCostFuelTankUpgrade.Text = "Cost: 25 metal";
            // 
            // labelCostEngineUpgrade
            // 
            this.labelCostEngineUpgrade.AutoSize = true;
            this.labelCostEngineUpgrade.BackColor = System.Drawing.Color.Transparent;
            this.labelCostEngineUpgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCostEngineUpgrade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCostEngineUpgrade.Location = new System.Drawing.Point(190, 365);
            this.labelCostEngineUpgrade.Name = "labelCostEngineUpgrade";
            this.labelCostEngineUpgrade.Size = new System.Drawing.Size(150, 25);
            this.labelCostEngineUpgrade.TabIndex = 5;
            this.labelCostEngineUpgrade.Text = "Cost: 50 metal";
            // 
            // labelCostBatteryUpgrade
            // 
            this.labelCostBatteryUpgrade.AutoSize = true;
            this.labelCostBatteryUpgrade.BackColor = System.Drawing.Color.Transparent;
            this.labelCostBatteryUpgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCostBatteryUpgrade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCostBatteryUpgrade.Location = new System.Drawing.Point(634, 365);
            this.labelCostBatteryUpgrade.Name = "labelCostBatteryUpgrade";
            this.labelCostBatteryUpgrade.Size = new System.Drawing.Size(150, 25);
            this.labelCostBatteryUpgrade.TabIndex = 6;
            this.labelCostBatteryUpgrade.Text = "Cost: 25 metal";
            // 
            // Notice
            // 
            this.Notice.AutoSize = true;
            this.Notice.BackColor = System.Drawing.Color.Transparent;
            this.Notice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Notice.ForeColor = System.Drawing.SystemColors.Control;
            this.Notice.Location = new System.Drawing.Point(668, 613);
            this.Notice.Name = "Notice";
            this.Notice.Size = new System.Drawing.Size(328, 25);
            this.Notice.TabIndex = 7;
            this.Notice.Text = "**Any work of upgrade-10 energy";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelCostMetalStorageUpgrade
            // 
            this.labelCostMetalStorageUpgrade.AutoSize = true;
            this.labelCostMetalStorageUpgrade.BackColor = System.Drawing.Color.Transparent;
            this.labelCostMetalStorageUpgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCostMetalStorageUpgrade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCostMetalStorageUpgrade.Location = new System.Drawing.Point(634, 108);
            this.labelCostMetalStorageUpgrade.Name = "labelCostMetalStorageUpgrade";
            this.labelCostMetalStorageUpgrade.Size = new System.Drawing.Size(150, 25);
            this.labelCostMetalStorageUpgrade.TabIndex = 9;
            this.labelCostMetalStorageUpgrade.Text = "Cost: 35 metal";
            // 
            // buttonUpgradeMetalStorage
            // 
            this.buttonUpgradeMetalStorage.BackColor = System.Drawing.Color.DarkGray;
            this.buttonUpgradeMetalStorage.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpgradeMetalStorage.Location = new System.Drawing.Point(639, 136);
            this.buttonUpgradeMetalStorage.Name = "buttonUpgradeMetalStorage";
            this.buttonUpgradeMetalStorage.Size = new System.Drawing.Size(200, 200);
            this.buttonUpgradeMetalStorage.TabIndex = 8;
            this.buttonUpgradeMetalStorage.Text = "Upgrade Metal Storage";
            this.buttonUpgradeMetalStorage.UseVisualStyleBackColor = false;
            this.buttonUpgradeMetalStorage.Click += new System.EventHandler(this.buttonUpgradeMetalStorage_Click);
            // 
            // progressBarMetal
            // 
            this.progressBarMetal.Location = new System.Drawing.Point(16, 152);
            this.progressBarMetal.Name = "progressBarMetal";
            this.progressBarMetal.Size = new System.Drawing.Size(116, 28);
            this.progressBarMetal.TabIndex = 19;
            // 
            // progressBarEnergy
            // 
            this.progressBarEnergy.Location = new System.Drawing.Point(16, 94);
            this.progressBarEnergy.Name = "progressBarEnergy";
            this.progressBarEnergy.Size = new System.Drawing.Size(116, 28);
            this.progressBarEnergy.TabIndex = 18;
            // 
            // progressBarFuel
            // 
            this.progressBarFuel.Location = new System.Drawing.Point(16, 36);
            this.progressBarFuel.Name = "progressBarFuel";
            this.progressBarFuel.Size = new System.Drawing.Size(116, 28);
            this.progressBarFuel.TabIndex = 17;
            // 
            // eCapacity
            // 
            this.eCapacity.AutoSize = true;
            this.eCapacity.BackColor = System.Drawing.Color.Transparent;
            this.eCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eCapacity.ForeColor = System.Drawing.SystemColors.Control;
            this.eCapacity.Location = new System.Drawing.Point(12, 67);
            this.eCapacity.Name = "eCapacity";
            this.eCapacity.Size = new System.Drawing.Size(92, 24);
            this.eCapacity.TabIndex = 14;
            this.eCapacity.Text = "eCapacity";
            // 
            // mCapacity
            // 
            this.mCapacity.AutoSize = true;
            this.mCapacity.BackColor = System.Drawing.Color.Transparent;
            this.mCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mCapacity.ForeColor = System.Drawing.SystemColors.Control;
            this.mCapacity.Location = new System.Drawing.Point(12, 125);
            this.mCapacity.Name = "mCapacity";
            this.mCapacity.Size = new System.Drawing.Size(97, 24);
            this.mCapacity.TabIndex = 16;
            this.mCapacity.Text = "mCapacity";
            // 
            // fCapacity
            // 
            this.fCapacity.AutoSize = true;
            this.fCapacity.BackColor = System.Drawing.Color.Transparent;
            this.fCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fCapacity.ForeColor = System.Drawing.SystemColors.Control;
            this.fCapacity.Location = new System.Drawing.Point(12, 9);
            this.fCapacity.Name = "fCapacity";
            this.fCapacity.Size = new System.Drawing.Size(85, 24);
            this.fCapacity.TabIndex = 15;
            this.fCapacity.Text = "fCapacity";
            // 
            // Garage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CosmStarategy.Resource1.garageBack;
            this.ClientSize = new System.Drawing.Size(1008, 647);
            this.Controls.Add(this.progressBarMetal);
            this.Controls.Add(this.progressBarEnergy);
            this.Controls.Add(this.progressBarFuel);
            this.Controls.Add(this.eCapacity);
            this.Controls.Add(this.mCapacity);
            this.Controls.Add(this.fCapacity);
            this.Controls.Add(this.labelCostMetalStorageUpgrade);
            this.Controls.Add(this.buttonUpgradeMetalStorage);
            this.Controls.Add(this.Notice);
            this.Controls.Add(this.labelCostBatteryUpgrade);
            this.Controls.Add(this.labelCostEngineUpgrade);
            this.Controls.Add(this.labelCostFuelTankUpgrade);
            this.Controls.Add(this.buttonUpgradeBattery);
            this.Controls.Add(this.buttonUpgradeFuelTank);
            this.Controls.Add(this.buttonUpgradeEngine);
            this.Controls.Add(this.label1);
            this.Name = "Garage";
            this.Text = "Garage";
            this.Load += new System.EventHandler(this.Garage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUpgradeEngine;
        private System.Windows.Forms.Button buttonUpgradeFuelTank;
        private System.Windows.Forms.Button buttonUpgradeBattery;
        private System.Windows.Forms.Label labelCostFuelTankUpgrade;
        private System.Windows.Forms.Label labelCostEngineUpgrade;
        private System.Windows.Forms.Label labelCostBatteryUpgrade;
        private System.Windows.Forms.Label Notice;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelCostMetalStorageUpgrade;
        private System.Windows.Forms.Button buttonUpgradeMetalStorage;
        private System.Windows.Forms.ProgressBar progressBarMetal;
        private System.Windows.Forms.ProgressBar progressBarEnergy;
        private System.Windows.Forms.ProgressBar progressBarFuel;
        private System.Windows.Forms.Label eCapacity;
        private System.Windows.Forms.Label mCapacity;
        private System.Windows.Forms.Label fCapacity;
    }
}