using CosmStarategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmStarategy.Buildings
{
    internal class GarageClas : Building
    {
        private SpaceShip shipSpek = SpaceShip.init();
        public static int costEngineUpgrade { get; } = 50;
        public static int costFuelTankUpgrade { get; } = 25;
        public static int costBatteryUpgrade { get; } = 25;
        public static int costMetalStorageUpgrade { get; } = 35;
        public static int EnergyForUpgrade { get; } = 10;
        public Boolean indicatorFuel { get; set; }
        public Boolean indicatorMetal { get; set; }
        public Boolean indicatorBattery { get; set; }
        public Boolean indicatorEngine { get; set; }
        public GarageClas() 
        {
            name = "Garage";
            res = new List<absResource>() { new Fuel(5) };
            isAvailable = true;
            level = 0;
            endurance = 100;
            capacity = 10;
        }
        public void UpgradeFuelTank()
        {
            if (shipSpek.MetalValue >= costEngineUpgrade && shipSpek.EnergyValue >= EnergyForUpgrade && shipSpek.LevelOfFuelTank==1)
            {
                shipSpek.LevelOfFuelTank += 1;
                shipSpek.DecreaseMetal(costFuelTankUpgrade);
                shipSpek.DecreaseEnergy(EnergyForUpgrade);
                shipSpek.FuelCapacity *= 2;
            }
            else
            {
                if (shipSpek.LevelOfFuelTank == 2)
                {
                    WarningLvl();
                }
                else
                {
                    WarningValue();
                }

            }
        }
        public void UpgradeBattery()
        {
            if (shipSpek.MetalValue >= costEngineUpgrade && shipSpek.EnergyValue >= EnergyForUpgrade && shipSpek.LevelOfBattery == 1)
            {
                shipSpek.LevelOfBattery += 1;
                shipSpek.DecreaseMetal(costBatteryUpgrade);
                shipSpek.DecreaseEnergy(EnergyForUpgrade);
                shipSpek.EnergyCapacity *= 2;
            }
            else
            {
                if (shipSpek.LevelOfBattery == 2)
                {
                    WarningLvl();
                }
                else
                {
                    WarningValue();
                }

            }
        }
        public void UpgradeEngine()
        {
            if (shipSpek.MetalValue >= costEngineUpgrade && shipSpek.EnergyValue >= EnergyForUpgrade && shipSpek.LevelOfEngine == 1)
            {
                shipSpek.LevelOfEngine += 1;
                shipSpek.DecreaseMetal(costEngineUpgrade);
                shipSpek.DecreaseEnergy(EnergyForUpgrade);
            }
            else
            {
                if (shipSpek.LevelOfEngine == 2)
                {
                    WarningLvl();
                }
                else
                {
                    WarningValue();
                }

            }
        }
        public void UpgradeMetalStorage()
        {
            if (shipSpek.MetalValue >= costEngineUpgrade && shipSpek.EnergyValue >= EnergyForUpgrade && shipSpek.LevelOfMetalStorage == 1)
            {
                shipSpek.LevelOfMetalStorage += 1;
                shipSpek.DecreaseMetal(costMetalStorageUpgrade);
                shipSpek.DecreaseEnergy(EnergyForUpgrade);
                shipSpek.speed /= 2;
            }
            else
            {
                if (shipSpek.LevelOfMetalStorage == 2)
                {
                    WarningLvl();
                }
                else
                {
                    WarningValue();
                }

            }
        }
        public void WarningLvl()
        {
            MessageBox.Show("У тебя максимальный уровень!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void WarningValue()
        {
            MessageBox.Show("У тебя не хватает металла или энергии!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }




    }
}
