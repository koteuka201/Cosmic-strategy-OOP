using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CosmStarategy.Resources
{
    internal class Metal : absResource
    {
        public Metal(int cnt)
        {
            name = "Metal";
            count = cnt;
        }
    }
}
