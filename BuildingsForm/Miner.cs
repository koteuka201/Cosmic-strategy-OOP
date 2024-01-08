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
    public partial class Miner : Form
    {
        private SpaceShip shipSpek = SpaceShip.init();
        public Miner()
        {
            InitializeComponent();

            progressBarFuel.Maximum = shipSpek.FuelCapacity;
            progressBarEnergy.Maximum = shipSpek.EnergyCapacity;
            progressBarMetal.Maximum = shipSpek.MetalCapacity;

            progressBarFuel.DataBindings.Add("Value", shipSpek, "FuelValue");
            progressBarEnergy.DataBindings.Add("Value", shipSpek, "EnergyValue");
            progressBarMetal.DataBindings.Add("Value", shipSpek, "MetalValue");
        }

        private void buttonCollectMetal_Click(object sender, EventArgs e)
        {
            MinerMetal minerMetal = new MinerMetal();
            minerMetal.MineMetal();
            refreshInterface();
        }
        public void refreshInterface()
        {
            mCapacity.Text = "Metal: " + shipSpek.MetalValue.ToString();
            fCapacity.Text = "Fuel: " + shipSpek.FuelValue.ToString();
            eCapacity.Text = "Energy: " + shipSpek.EnergyValue.ToString();
        }

        private void Miner_Load(object sender, EventArgs e)
        {
            refreshInterface();
        }
    }
}
