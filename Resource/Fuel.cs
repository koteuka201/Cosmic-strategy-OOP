using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmStarategy
{
    internal class Fuel : absResource
    {
        public Fuel(int cnt) {
            name = "Fuel";
            count = cnt;
        }
    }
}
