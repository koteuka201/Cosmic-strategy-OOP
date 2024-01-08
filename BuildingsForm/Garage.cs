using CosmStarategy.Buildings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmStarategy
{
    public partial class Garage : Form
    {
        private SpaceShip shipSpek = SpaceShip.init();
        public static int costEngineUpgrade { get; } = 50;
        public static int costFuelTankUpgrade { get; } = 25;
        public static int costBatteryUpgrade { get; } = 25;
        public static int costMetalStorageUpgrade { get; } = 35;
        public static int EnergyForUpgrade { get; } = 10;
        public Boolean indicatorFuel { get; set; }
        public Boolean indicatorMetal { get; set; }
        public Boolean indicatorBattery { get; set; }
        public Boolean indicatorEngine { get; set; }
        public Garage()
        {
            InitializeComponent();

            progressBarFuel.Maximum = shipSpek.FuelCapacity;
            progressBarEnergy.Maximum = shipSpek.EnergyCapacity;
            progressBarMetal.Maximum = shipSpek.MetalCapacity;

            progressBarFuel.DataBindings.Add("Value", shipSpek, "FuelValue");
            progressBarEnergy.DataBindings.Add("Value", shipSpek, "EnergyValue");
            progressBarMetal.DataBindings.Add("Value", shipSpek, "MetalValue");

        }

        private void Garage_Load(object sender, EventArgs e)
        {
            refreshInterface();
        }
        private void buttonUpgradeFuelTank_Click(object sender, EventArgs e)
        {
            GarageClas garage= new GarageClas();
            garage.UpgradeFuelTank();
            progressBarFuel.Maximum = shipSpek.FuelCapacity;
            refreshInterface();
        }
        private void buttonUpgradeEngine_Click(object sender, EventArgs e)
        {
            GarageClas garage = new GarageClas();
            garage.UpgradeEngine();
            progressBarFuel.Maximum = shipSpek.FuelCapacity;
            refreshInterface();
        }
        private void buttonUpgradeMetalStorage_Click(object sender, EventArgs e)
        {
            GarageClas garage = new GarageClas();
            garage.UpgradeMetalStorage();
            progressBarFuel.Maximum = shipSpek.FuelCapacity;
            refreshInterface();
        }
        private void buttonUpgradeBattery_Click(object sender, EventArgs e)
        {
            GarageClas garage = new GarageClas();
            garage.UpgradeBattery();
            progressBarEnergy.Maximum = shipSpek.EnergyCapacity;
            refreshInterface();
        }
        public void WarningLvl()
        {
            MessageBox.Show("У тебя максимальный уровень!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void WarningValue()
        {
            MessageBox.Show("У тебя не хватает металла или энергии!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void refreshInterface()
        {
            mCapacity.Text = "Metal: " + shipSpek.MetalValue.ToString();
            fCapacity.Text = "Fuel: " + shipSpek.FuelValue.ToString();
            eCapacity.Text = "Energy: " + shipSpek.EnergyValue.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

    }
}
