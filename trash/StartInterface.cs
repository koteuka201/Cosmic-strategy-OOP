using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CosmStarategy
{
    internal class StartInterface
    {
        public void SetupShipControls(List<Label> ShipIndicators)
        {
            foreach (var label in ShipIndicators) 
            {
                label.BackColor = Color.Transparent;
            }
        }
    }
}
