using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CosmStarategy;

namespace CosmStarategy.Buildings
{
	internal class BoreHole : Building
	{
        static int amountOfFuel { get; } = 5;
        private SpaceShip shipSpek = SpaceShip.init();
        public BoreHole()
		{
			name = "BoreHole";
			res = new List<absResource>() { new Fuel(5)};
            isAvailable = true;
            level = 0;
            endurance = 100;
            capacity = 10;
        }
        
        public void mineFuel()
        {
            if (shipSpek.FuelValue + amountOfFuel <= shipSpek.FuelCapacity)
            {
                shipSpek.FuelValue += amountOfFuel;
            }
            else
            {
                MessageBox.Show("Бак полон!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
		private void MakeResource(int amount)
		{
			res.Add(new Fuel(amount));
        }

        public override void CreateResource()
        {
			MakeResource(1);
        }
    }
}