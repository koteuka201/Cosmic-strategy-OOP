using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CosmStarategy;
using CosmStarategy.Resources;

namespace CosmStarategy.Buildings
{
    internal class PowerPlant : Building
    {
        static int amountOfEnergy { get; } = 5;
        private SpaceShip shipSpek = SpaceShip.init();
        public PowerPlant()
        {
            name = "PowerPlant";
            res = new List<absResource>() { new Energy(5) };
            isAvailable = true;
            level = 0;
            endurance = 100;
            capacity = 10;
        }

        public void CollectEnergyOnShip()
        {
            if(shipSpek.EnergyValue+amountOfEnergy <= shipSpek.EnergyCapacity)
            {
                shipSpek.EnergyValue += amountOfEnergy;
            }
            else
            {
                MessageBox.Show("Аккумулятор полон!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void MakeResource(int amount)
        {
            res.Add(new Energy(5));
        }

        public override void CreateResource()
        {
            MakeResource(1);
        }

    }
}
