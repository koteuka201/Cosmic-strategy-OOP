using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmStarategy
{
    internal class Components
    {
        public int LevelOfBattery { get; private set; }
        public int LevelOfFuelTank { get; private set; }
        Components()
        {
            LevelOfBattery = 1;
        }
    }
}
