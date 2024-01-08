using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CosmStarategy.Buildings;

namespace CosmStarategy.Buildings
{
    internal class Provider
    {
        private Building value;

        private Dictionary<string, Building> build = new Dictionary<string, Building>()
        {
            {"BoreHole", new BoreHole()},{ "StorageOfMetal", new MinerMetal()},{ "PowerPlant", new PowerPlant()},{ "ChillRoom", new ChillRoom()},{"ExchangeTerminal", new ExchangeTerminal()},{"Gallery", new Gallery()},{"MemRoom", new MemRoom()},{"Planitatium", new Planitarium()},{"TGU", new TGU()},{"Garage", new GarageClas()}  

        };

        public Provider(string name) 
        {
            value = convert(name);
        }

        private Building convert(string s)
        {
            return build[s];
        }

        public Building GetBuilding()
        {
            return value;
        }

    }
}
