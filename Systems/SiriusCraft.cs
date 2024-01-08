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
    public partial class SiriusCraft : Form
    {
        private SpaceShip shipSpek = SpaceShip.init();
        public Bitmap ship = Resource1.ship2;
        private PictureBox starShip;
        public SiriusCraft()
        {
            InitializeComponent();

            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint, true);

            //shipSpek = existingShip;

            ElipseButton.MakeButtonRound(buttonCrait);
            ElipseButton.MakeButtonRound(buttonPandora);
            ElipseButton.MakeButtonRound(buttonKamino);

            starShip = new PictureBox();
            starShip = MakeShipOnForm.CreateShip(starShip, ship, ClientSize.Width / 2, 500);

            progressBarFuel.Maximum = shipSpek.FuelCapacity;//изменить
            progressBarEnergy.Maximum = shipSpek.EnergyCapacity;
            progressBarMetal.Maximum = shipSpek.MetalCapacity;

            progressBarFuel.DataBindings.Add("Value", shipSpek, "FuelValue");
            progressBarEnergy.DataBindings.Add("Value", shipSpek, "EnergyValue");
            progressBarMetal.DataBindings.Add("Value", shipSpek, "MetalValue");

            Controls.Add(starShip);
        }

        private async void buttonBackToMain_Click_1(object sender, EventArgs e)
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

        private void SiriusCraft_Load(object sender, EventArgs e)
        {
            refreshInterface();
        }

        
        private void SiriusCraft_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(starShip.Image, starShip.Location);
        }
        void refreshInterface()
        {
            mCapacity.Text = "Metal: " + shipSpek.MetalValue.ToString();
            fCapacity.Text = "Fuel: " + shipSpek.FuelValue.ToString();
            eCapacity.Text = "Energy: " + shipSpek.EnergyValue.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private async void buttonCrait_Click(object sender, EventArgs e)
        {
            int x = buttonCrait.Left + (buttonCrait.Width - starShip.Width) / 2;
            int y = buttonCrait.Top + (buttonCrait.Height - starShip.Height) / 2;

            if (shipSpek.FuelValue >= SpaceShip.costToPlanetAndBuildFuel && shipSpek.EnergyValue >= SpaceShip.costToPlanetAndBuildEnergy)
            {
                await ShipMovement.MoveShip(starShip, x, y, shipSpek.speed, shipSpek.LevelOfEngine);
                shipSpek.DecreaseFuel(SpaceShip.costToSystemFuel);
                shipSpek.DecreaseEnergy(SpaceShip.costToSystemEnergy);
                refreshInterface();
                this.Hide();
                Crait crait = new Crait();
                crait.Show();
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

        private async void buttonPandora_Click(object sender, EventArgs e)
        {
            int x = buttonPandora.Left + (buttonPandora.Width - starShip.Width) / 2;
            int y = buttonPandora.Top + (buttonPandora.Height - starShip.Height) / 2;

            if (shipSpek.FuelValue >= SpaceShip.costToPlanetAndBuildFuel && shipSpek.EnergyValue >= SpaceShip.costToPlanetAndBuildEnergy)
            {
                await ShipMovement.MoveShip(starShip, x, y, shipSpek.speed, shipSpek.LevelOfEngine);
                shipSpek.DecreaseFuel(SpaceShip.costToSystemFuel);
                shipSpek.DecreaseEnergy(SpaceShip.costToSystemEnergy);
                refreshInterface();
                this.Hide();
                Pandora pandora = new Pandora();
                pandora.Show();
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

        private async void buttonKamino_Click(object sender, EventArgs e)
        {
            int x = buttonKamino.Left + (buttonKamino.Width - starShip.Width) / 2;
            int y = buttonKamino.Top + (buttonKamino.Height - starShip.Height) / 2;

            if (shipSpek.FuelValue >= SpaceShip.costToPlanetAndBuildFuel && shipSpek.EnergyValue >= SpaceShip.costToPlanetAndBuildEnergy)
            {
                await ShipMovement.MoveShip(starShip, x, y, shipSpek.speed, shipSpek.LevelOfEngine);
                shipSpek.DecreaseFuel(SpaceShip.costToSystemFuel);
                shipSpek.DecreaseEnergy(SpaceShip.costToSystemEnergy);
                refreshInterface();
                this.Hide();
                Kamino kamino = new Kamino();
                kamino.Show();
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
