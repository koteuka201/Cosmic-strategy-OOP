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
    public partial class PetrolStation : Form
    {
        private SpaceShip shipSpek = SpaceShip.init();
        public PetrolStation()
        {
            InitializeComponent();

            progressBarFuel.Maximum = shipSpek.FuelCapacity;
            progressBarEnergy.Maximum = shipSpek.EnergyCapacity;
            progressBarMetal.Maximum = shipSpek.MetalCapacity;

            progressBarFuel.DataBindings.Add("Value", shipSpek, "FuelValue");
            progressBarEnergy.DataBindings.Add("Value", shipSpek, "EnergyValue");
            progressBarMetal.DataBindings.Add("Value", shipSpek, "MetalValue");
        }

        private void Petro_Station_Load(object sender, EventArgs e)
        {
            refreshInterface();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }
        public void refreshInterface()
        {
            mCapacity.Text = "Metal: " + shipSpek.MetalValue.ToString();
            fCapacity.Text = "Fuel: " + shipSpek.FuelValue.ToString();
            eCapacity.Text = "Energy: " + shipSpek.EnergyValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BoreHole boreHole = new BoreHole();
            boreHole.mineFuel();
            refreshInterface();
        }
    }
}
