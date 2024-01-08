using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CosmStarategy.Buildings;

namespace CosmStarategy.Buildings
{
    internal class MemRoom : Building
    {
        public MemRoom()
        {
            name = "MemRoom";
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
            //str += "ТУТ БУДЕТ АНЕКДОТ!!!!!!!!!!!!!!";
            return str;
        }
        //листенер на клик
    }
}
