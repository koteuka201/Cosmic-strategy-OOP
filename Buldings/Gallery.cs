using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CosmStarategy.Buildings;

namespace CosmStarategy.Buildings
{
    internal class Gallery : Building
    {
        public Gallery()
        {
            name = "Gallery";
            isAvailable = true;
            level = 12000;
            endurance = 100;
            capacity = 10;
        }

        public override string GetInfo()
        {
            string str = "";
            str += name + "\r\n";
            str += "Level " + level.ToString() + "\r\n";
            str += "1. В России — разруха.\r\n2. Транспорт сломан.\r\n3. Ты должен подумать, как выйти из этого положения.\r\n4. Делай предложения!\r\n\r\n Владимир Маяковский" + "\r\n";
            return str;
        }

    }
}
