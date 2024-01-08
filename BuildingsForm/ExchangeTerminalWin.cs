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
    public partial class ExchangeTerminalWin : Form
    {
        private SpaceShip shipSpek = SpaceShip.init();
        public string ResourseToGive { get; set; }
        public string ResourseToGet { get; set; }
        public int amountOfTrade { get; set; }
        public ExchangeTerminalWin()
        {
            InitializeComponent();

            progressBarFuel.Maximum = shipSpek.FuelCapacity;
            progressBarEnergy.Maximum = shipSpek.EnergyCapacity;
            progressBarMetal.Maximum = shipSpek.MetalCapacity;

            progressBarFuel.DataBindings.Add("Value", shipSpek, "FuelValue");
            progressBarEnergy.DataBindings.Add("Value", shipSpek, "EnergyValue");
            progressBarMetal.DataBindings.Add("Value", shipSpek, "MetalValue");
            amountOfTrade = 10;
        }

        private void ExchangeTerminalWin_Load(object sender, EventArgs e)
        {
            refreshInterface();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            amountOfTrade = Convert.ToInt32(textBox1.Text);
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void buttonEnergy_Click(object sender, EventArgs e)
        {
            ResourseToGive = "Energy";
        }

        private void buttonFuel_Click(object sender, EventArgs e)
        {
            ResourseToGive = "Fuel";
        }

        private void buttonMetal_Click(object sender, EventArgs e)
        {
            ResourseToGive = "Metal";
        }

        private void buttonEnergyBuy_Click(object sender, EventArgs e)
        {
            ResourseToGet = "Energy";
            ExchangeTerminal exchangeTerminal=new ExchangeTerminal();
            exchangeTerminal.Trade(ResourseToGive, ResourseToGet, amountOfTrade);
            refreshInterface();
        }

        private void buttonFuelBuy_Click(object sender, EventArgs e)
        {
            ResourseToGet = "Fuel";
            ExchangeTerminal exchangeTerminal = new ExchangeTerminal();
            exchangeTerminal.Trade(ResourseToGive, ResourseToGet, amountOfTrade);
            refreshInterface();
        }

        private void buttonMetalBuy_Click(object sender, EventArgs e)
        {
            ResourseToGet = "Metal";
            ExchangeTerminal exchangeTerminal = new ExchangeTerminal();
            exchangeTerminal.Trade(ResourseToGive, ResourseToGet, amountOfTrade);
            refreshInterface();
        }
        public void refreshInterface()
        {
            mCapacity.Text = "Metal: " + shipSpek.MetalValue.ToString();
            fCapacity.Text = "Fuel: " + shipSpek.FuelValue.ToString();
            eCapacity.Text = "Energy: " + shipSpek.EnergyValue.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }
    }
}
