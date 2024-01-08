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
    
    public partial class Vectra : Form
    {
        private SpaceShip shipSpek = SpaceShip.init();
        public Bitmap ship = Resource1.ship2;
        private PictureBox starShip;
        public Vectra()
        {
            InitializeComponent();

            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint, true);

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

        private void Vectra_Load(object sender, EventArgs e)
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

        private async void buttonBuildings_Click(object sender, EventArgs e)
        {
            int x = buttonBuildings.Left + (buttonBuildings.Width - starShip.Width) / 2;
            int y = buttonBuildings.Top + (buttonBuildings.Height - starShip.Height) / 2;

            if (shipSpek.FuelValue >= SpaceShip.costToPlanetAndBuildFuel && shipSpek.EnergyValue >= SpaceShip.costToPlanetAndBuildEnergy)
            {
                await ShipMovement.MoveShip(starShip, x, y, shipSpek.speed, shipSpek.LevelOfEngine);
                shipSpek.DecreaseFuel(SpaceShip.costToSystemFuel);
                shipSpek.DecreaseEnergy(SpaceShip.costToSystemEnergy);
                refreshInterface();
                this.Hide();
                MapOFBuild mapOFBuild = new MapOFBuild();
                mapOFBuild.Show();
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

        private async void buttonBackToPlanets_Click(object sender, EventArgs e)
        {
            int x = buttonBackToPlanets.Left + (buttonBackToPlanets.Width - starShip.Width) / 2;
            int y = buttonBackToPlanets.Top + (buttonBackToPlanets.Height - starShip.Height) / 2;

            if (shipSpek.FuelValue >= SpaceShip.costToPlanetAndBuildFuel && shipSpek.EnergyValue >= SpaceShip.costToPlanetAndBuildEnergy)
            {
                await ShipMovement.MoveShip(starShip, x, y, shipSpek.speed, shipSpek.LevelOfEngine);
                shipSpek.DecreaseFuel(SpaceShip.costToPlanetAndBuildFuel);
                shipSpek.DecreaseEnergy(SpaceShip.costToPlanetAndBuildEnergy);
                refreshInterface();
                this.Hide();
                VegaCraft vegaCraft = new VegaCraft();
                vegaCraft.Show();
            }
            else
            {
                if (shipSpek.FuelValue < SpaceShip.costToPlanetAndBuildFuel)
                {
                    MessageBox.Show("У тебя не хватает топлива!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("У тебя не хватает энергии!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Vectra_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(starShip.Image, starShip.Location);
        }
    }
}
