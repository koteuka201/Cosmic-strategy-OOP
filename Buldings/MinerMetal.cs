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
    internal class MinerMetal : Building
    {
        static int amountOfMetal { get; } = 5;
        private SpaceShip shipSpek = SpaceShip.init();
        public MinerMetal()
        {
            name = "StorageOfMetal";
            res = new List<absResource>() { new Metal(5) };
            isAvailable = true;
            level = 0;
            endurance = 100;
            capacity = 10;
        }

        public void MineMetal()
        {
            if (shipSpek.MetalValue + amountOfMetal <= shipSpek.MetalCapacity)
            {
                shipSpek.MetalValue += amountOfMetal;
            }
            else
            {
                MessageBox.Show("Хранилище заполнено!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void MakeResource(int amount)
        {
            res.Add(new Metal(5));
        }

        public override void CreateResource()
        {
            MakeResource(1);
        }
    }

}
