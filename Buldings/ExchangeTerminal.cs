using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmStarategy.Buildings
{
    internal class ExchangeTerminal : Building
    {
        private SpaceShip shipSpek = SpaceShip.init();
        public int exchangeRate;

        public ExchangeTerminal()
        {
            name = "ExchangeTerminal";
            res = new List<absResource>() { new Fuel(5) };
            isAvailable = true;
            level = 0;
            endurance = 100;
            capacity = 10;
        }
        public void Trade(string giveType, string getType, int valueOfTrade)
        {

            if (giveType == "Energy")
            {
                if (getType == "Metal")
                {
                    if (shipSpek.EnergyValue >= valueOfTrade && (shipSpek.MetalValue+valueOfTrade)<=shipSpek.MetalCapacity)
                    {
                        shipSpek.EnergyValue -= valueOfTrade;
                        shipSpek.MetalValue += valueOfTrade;
                    }
                    else
                    {
                        MessageBox.Show("У тебя не хватает энергии!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (getType != "Energy")
                    {
                        if (shipSpek.EnergyValue >= valueOfTrade && (shipSpek.FuelValue + valueOfTrade) <= shipSpek.FuelCapacity)
                        {
                            shipSpek.EnergyValue -= valueOfTrade;
                            shipSpek.FuelValue += valueOfTrade;
                        }
                        else
                        {
                            MessageBox.Show("У тебя не хватает энергии!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            if (giveType == "Metal")
            {
                if(getType == "Fuel")
                {
                    if (shipSpek.MetalValue >= valueOfTrade && (shipSpek.FuelValue + valueOfTrade) <= shipSpek.FuelCapacity)
                    {
                        shipSpek.MetalValue -= valueOfTrade;
                        shipSpek.FuelValue += valueOfTrade;

                    }
                    else
                    {
                        MessageBox.Show("У тебя не хватает металла!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (getType != "Metal")
                    {
                        if (shipSpek.MetalValue >= valueOfTrade && (shipSpek.EnergyValue + valueOfTrade) <= shipSpek.EnergyCapacity)
                        {
                            shipSpek.MetalValue -= valueOfTrade;
                            shipSpek.EnergyValue += valueOfTrade;
                        }
                        else
                        {
                            MessageBox.Show("У тебя не хватает металла!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            if(giveType == "Fuel")
            {
                if (getType == "Metal")
                {
                    if(shipSpek.FuelValue >= valueOfTrade && (shipSpek.MetalValue + valueOfTrade) <= shipSpek.MetalCapacity)
                    {
                        shipSpek.FuelValue -= valueOfTrade;
                        shipSpek.MetalValue += valueOfTrade;
                    }
                    else
                    {
                        MessageBox.Show("У тебя не хватает топлива!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if(getType != "Fuel")
                    {
                        if (shipSpek.FuelCapacity >= valueOfTrade && (shipSpek.EnergyValue + valueOfTrade) <= shipSpek.EnergyCapacity)
                        {
                            shipSpek.FuelValue -= valueOfTrade;
                            shipSpek.EnergyValue += valueOfTrade;
                        }
                        else
                        {
                            MessageBox.Show("У тебя не хватает топлива!", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }
    }
}
