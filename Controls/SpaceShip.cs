using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmStarategy
{
    public class SpaceShip
    {
        private static SpaceShip instance=null;
        private Components battery;
        public int MetalValue { get; set; }
        public int FuelValue { get; set; }
        public int EnergyValue { get; set; }  
        public int speed { get; set; }
        public int LevelOfEngine { get; set; }
        public int LevelOfFuelTank { get; set; }
        public int LevelOfMetalStorage { get; set; }
        public int LevelOfBattery { get; set; }
        public int MetalCapacity { get; set; }
        public int FuelCapacity { get; set; }
        public int EnergyCapacity { get; set; }
        public static int costToSystemFuel { get; } = 20;
        public static int costToPlanetAndBuildFuel { get; } = 10;
        public static int costToSystemEnergy { get; } = 10;
        public static int costToPlanetAndBuildEnergy { get; } = 5;
        public static int speedOfDecayEnergy { get; } = 1;
        private SpaceShip()
        {
            LevelOfFuelTank = 1;
            LevelOfMetalStorage = 1;
            LevelOfBattery = 1;
            LevelOfEngine = 1;
            FuelCapacity = 500;
            EnergyCapacity = 500;
            MetalCapacity = 500;
            MetalValue = MetalCapacity/2;
            FuelValue = FuelCapacity/2;
            EnergyValue = EnergyCapacity/2;
            speed = 300;
        }
        public void DecreaseFuel(int amount)
        {
            FuelValue -= amount;
        }
        public void DecreaseEnergy(int amount)
        {
            EnergyValue -= amount;
        }
        public void DecreaseMetal(int amount) 
        {
            MetalValue -= amount;
        }
        public static SpaceShip init()
        {
            if (instance == null)
            {
                instance = new SpaceShip();
            }
            return instance;
        }
        public void SetupShipControls(List<Label> ShipIndicators)
        {
            foreach (var label in ShipIndicators)
            {
                label.BackColor = Color.Transparent;
            }
        }
        public void RefreshInterface()
        {

        }
    }
}
