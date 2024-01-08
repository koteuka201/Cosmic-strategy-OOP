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
    public partial class VegaCraft : Form
    {
        private SpaceShip shipSpek = SpaceShip.init();
        public Bitmap ship = Resource1.ship2;
        private PictureBox starShip;
        public VegaCraft()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint, true);

            ElipseButton.MakeButtonRound(buttonAiris);
            ElipseButton.MakeButtonRound(buttonVectra);
            ElipseButton.MakeButtonRound(buttonUltima);

            starShip = new PictureBox();
            starShip = MakeShipOnForm.CreateShip(starShip, ship, ClientSize.Width / 2, 500);

            progressBarFuel.Maximum = shipSpek.FuelCapacity;
            progressBarEnergy.Maximum = shipSpek.EnergyCapacity;
            progressBarMetal.Maximum = shipSpek.MetalCapacity;

            progressBarFuel.DataBindings.Add("Value", shipSpek, "FuelValue");
            progressBarEnergy.DataBindings.Add("Value", shipSpek, "EnergyValue");
            progressBarMetal.DataBindings.Add("Value", shipSpek, "MetalValue");

            Controls.Add(starShip);
        }

        private void VegaCraft_Load(object sender, EventArgs e)
        {
            refreshInterface();
        }
        void refreshInterface()
        {
            mCapacity.Text = "Metal: " + shipSpek.MetalValue.ToString();
            fCapacity.Text = "Fuel: " + shipSpek.FuelValue.ToString();
            eCapacity.Text = "Energy: " + shipSpek.EnergyValue.ToString();
        }

        private async void buttonBackToMain_Click(object sender, EventArgs e)
        {
            int x = buttonBackToMain.Left + (buttonBackToMain.Width - starShip.Width) / 2;
            int y = buttonBackToMain.Top + (buttonBackToMain.Height - starShip.Height) / 2;

            if (shipSpek.FuelValue >= SpaceShip.costToSystemFuel && shipSpek.EnergyValue >= SpaceShip.costToSystemEnergy)
            {
                await ShipMovement.MoveShip(starShip, x, y, shipSpek.speed, shipSpek.LevelOfEngine);
                shipSpek.DecreaseFuel(SpaceShip.costToSystemFuel);
                shipSpek.DecreaseEnergy(SpaceShip.costToSystemEnergy);
                refreshInterface();
                this.Hide();
                MainCraft mainCraft = new MainCraft();
                mainCraft.Show();
            }
            else
            {
                if (shipSpek.FuelValue < SpaceShip.costToSystemFuel)
                {
                    MessageBox.Show("У тебя не хватает топлива!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("У тебя не хватает энергии!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void VegaCraft_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(starShip.Image, starShip.Location);
        }

        private async void buttonAiris_Click(object sender, EventArgs e)
        {
            int x = buttonAiris.Left + (buttonAiris.Width - starShip.Width) / 2;
            int y = buttonAiris.Top + (buttonAiris.Height - starShip.Height) / 2;

            if (shipSpek.FuelValue >= SpaceShip.costToPlanetAndBuildFuel && shipSpek.EnergyValue >= SpaceShip.costToPlanetAndBuildEnergy)
            {
                await ShipMovement.MoveShip(starShip, x, y, shipSpek.speed, shipSpek.LevelOfEngine);
                shipSpek.DecreaseFuel(SpaceShip.costToSystemFuel);
                shipSpek.DecreaseEnergy(SpaceShip.costToSystemEnergy);
                refreshInterface();
                this.Hide();
                Airis airis = new Airis();
                airis.Show();
            }
            else
            {
                if (shipSpek.FuelValue < SpaceShip.costToPlanetAndBuildFuel)
                {
                    MessageBox.Show("Тебе не хватает топлива!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Тебе не хватает энергии!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private async void buttonVectra_Click(object sender, EventArgs e)
        {
            int x = buttonVectra.Left + (buttonVectra.Width - starShip.Width) / 2;
            int y = buttonVectra.Top + (buttonVectra.Height - starShip.Height) / 2;

            if (shipSpek.FuelValue >= SpaceShip.costToPlanetAndBuildFuel && shipSpek.EnergyValue >= SpaceShip.costToPlanetAndBuildEnergy)
            {
                await ShipMovement.MoveShip(starShip, x, y, shipSpek.speed, shipSpek.LevelOfEngine);
                shipSpek.DecreaseFuel(SpaceShip.costToSystemFuel);
                shipSpek.DecreaseEnergy(SpaceShip.costToSystemEnergy);
                refreshInterface();
                this.Hide();
                Vectra vectra = new Vectra();
                vectra.Show();
            }
            else
            {
                if (shipSpek.FuelValue < SpaceShip.costToPlanetAndBuildFuel)
                {
                    MessageBox.Show("Тебе не хватает топлива!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Тебе не хватает энергии!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private async void buttonUltima_Click(object sender, EventArgs e)
        {
            int x = buttonUltima.Left + (buttonUltima.Width - starShip.Width) / 2;
            int y = buttonUltima.Top + (buttonUltima.Height - starShip.Height) / 2;

            if (shipSpek.FuelValue >= SpaceShip.costToPlanetAndBuildFuel && shipSpek.EnergyValue >= SpaceShip.costToPlanetAndBuildEnergy)
            {
                await ShipMovement.MoveShip(starShip, x, y, shipSpek.speed, shipSpek.LevelOfEngine);
                shipSpek.DecreaseFuel(SpaceShip.costToSystemFuel);
                shipSpek.DecreaseEnergy(SpaceShip.costToSystemEnergy);
                refreshInterface();
                this.Hide();
                Ultima ultima = new Ultima();
                ultima.Show();
            }
            else
            {
                if (shipSpek.FuelValue < SpaceShip.costToPlanetAndBuildFuel)
                {
                    MessageBox.Show("Тебе не хватает топлива!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Тебе не хватает энергии!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
