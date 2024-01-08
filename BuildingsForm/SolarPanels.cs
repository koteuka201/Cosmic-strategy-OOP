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
    public partial class SolarPanels : Form
    {
        private SpaceShip shipSpek = SpaceShip.init();
        public SolarPanels()
        {
            InitializeComponent();

            progressBarFuel.Maximum = shipSpek.FuelCapacity;
            progressBarEnergy.Maximum = shipSpek.EnergyCapacity;
            progressBarMetal.Maximum = shipSpek.MetalCapacity;

            progressBarFuel.DataBindings.Add("Value", shipSpek, "FuelValue");
            progressBarEnergy.DataBindings.Add("Value", shipSpek, "EnergyValue");
            progressBarMetal.DataBindings.Add("Value", shipSpek, "MetalValue");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void buttonCollectEnergy_Click(object sender, EventArgs e)
        {
            PowerPlant powerPlant = new PowerPlant();
            powerPlant.CollectEnergyOnShip();
            refreshInterface();
        }
        public void refreshInterface()
        {
            mCapacity.Text = "Metal: " + shipSpek.MetalValue.ToString();
            fCapacity.Text = "Fuel: " + shipSpek.FuelValue.ToString();
            eCapacity.Text = "Energy: " + shipSpek.EnergyValue.ToString();
        }

        private void SolarPanels_Load(object sender, EventArgs e)
        {
            refreshInterface();
        }
    }
}
