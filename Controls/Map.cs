using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmStarategy.Buildings
{
    internal class Map
    {
        private List<List<Building>> buildings = new List<List<Building>>();
        public Map()
        {
            for (int i = 0; i < 6; i++)
            {
                buildings.Add(new List<Building>());
                for (int j = 0; j < 7; j++)
                {
                    buildings[i].Add(null);
                }
            }
        }

        public void AddBuilding(Building b, int x, int y, bool indicator)
        {
            buildings[x][y] = b;
            //indicator = true;
        }
        public string getName(int x, int y)
        {
            if (buildings[x][y] != null)
            {
                return buildings[x][y].GetName();
            }
            return "";
        }
        public string GetInfoBuilding(int x, int y)
        {
            if (buildings[x][y] != null)
            {
                return buildings[x][y].GetInfo();
            }
            else
            {
                return "Выбери здание!";
            }
        }
    }
}
