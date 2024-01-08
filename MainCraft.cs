using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CosmStarategy
{
    public partial class MainCraft : Form
    {
        //public static MainCraft Instance { get; private set; }
        private SpaceShip shipSpek = SpaceShip.init();
        public Bitmap ship = Resource1.ship2;
        public PictureBox starShip;
        public MainCraft()
        {
            InitializeComponent();
            //Instance = this;
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint, true);

            ElipseButton.MakeButtonRound(buttonSirius);
            ElipseButton.MakeButtonRound(buttonVega);

            starShip = new PictureBox();
            starShip = MakeShipOnForm.CreateShip(starShip, ship, ClientSize.Width / 2, 550);

            progressBarFuel.Maximum = shipSpek.FuelCapacity;//изменить
            progressBarEnergy.Maximum = shipSpek.EnergyCapacity;
            progressBarMetal.Maximum = shipSpek.MetalCapacity;

            progressBarFuel.DataBindings.Add("Value", shipSpek, "FuelValue");
            progressBarEnergy.DataBindings.Add("Value", shipSpek, "EnergyValue");
            progressBarMetal.DataBindings.Add("Value", shipSpek, "MetalValue");

            Controls.Add(starShip);

            buttonSirius.Click += buttonSirius_Click;

        }
        private void MainCraft_Load(object sender, EventArgs e)
        {
            refreshInterface();
        }
        private void energyTimer2_Tick(object sender, EventArgs e)
        {
            shipSpek.DecreaseEnergy(SpaceShip.speedOfDecayEnergy);
            eCapacity.Text = "Energy: " + shipSpek.EnergyValue.ToString();
            if (shipSpek.EnergyValue <= 0)
            {
                energyTimer2.Stop();
                MessageBox.Show("У тебя закончилась энергия!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private async void buttonSirius_Click(object sender, EventArgs e)
        {
            int x=buttonSirius.Left + (buttonSirius.Width - starShip.Width)/2;
            int y=buttonSirius.Top + (buttonSirius.Height - starShip.Height)/2;


            if (shipSpek.FuelValue >= SpaceShip.costToSystemFuel && shipSpek.EnergyValue >=SpaceShip.costToSystemEnergy)
            {

                await ShipMovement.MoveShip(starShip,x, y,shipSpek.speed, shipSpek.LevelOfEngine);
                shipSpek.DecreaseFuel(SpaceShip.costToSystemFuel);
                shipSpek.DecreaseEnergy(SpaceShip.costToSystemEnergy);
                refreshInterface();
                this.Hide();
                SiriusCraft siriusCraft = new SiriusCraft();
                siriusCraft.Show();
            }
            else
            {
                if (shipSpek.FuelValue < SpaceShip.costToSystemFuel)
                {
                    MessageBox.Show("У тебе не хватает топлива!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("У тебе не хватает энергии!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(starShip.Image, starShip.Location);
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

        private async void buttonVega_Click(object sender, EventArgs e)
        {
            int x = buttonVega.Left + (buttonVega.Width - starShip.Width) / 2;
            int y = buttonVega.Top + (buttonVega.Height - starShip.Height) / 2;


            if (shipSpek.FuelValue >= SpaceShip.costToSystemFuel && shipSpek.EnergyValue >= SpaceShip.costToSystemEnergy)
            {
                await ShipMovement.MoveShip(starShip, x, y, shipSpek.speed, shipSpek.LevelOfEngine);
                shipSpek.DecreaseFuel(SpaceShip.costToSystemFuel);
                shipSpek.DecreaseEnergy(SpaceShip.costToSystemEnergy);
                refreshInterface();
                this.Hide();
                VegaCraft vegaCraft = new VegaCraft();
                vegaCraft.Show();
            }
            else
            {
                if (shipSpek.FuelValue < SpaceShip.costToSystemFuel)
                {
                    MessageBox.Show("У тебе не хватает топлива!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("У тебе не хватает энергии!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
