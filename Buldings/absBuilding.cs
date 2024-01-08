using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using CosmStarategy;

namespace CosmStarategy.Buildings
{
    internal abstract class Building
    {
        protected int level;
        protected int endurance;
        protected int capacity;
        protected bool isAvailable;
        protected string name;
        protected List<absResource> res;

        public void upgrade()
        {
            this.isAvailable = true;
            this.level++;
            this.capacity += 10;
        }

        public void destroy()
        {
            this.isAvailable = false;
            this.level = 0;
            this.endurance = 0;
            this.capacity = 0;
        }

        public void rewindOfResources()
        {

        }

        public void getFromPlace(Building place)
        {
            
        }

        public virtual void CreateResource()
        {

        }

        public virtual string GetName()
        {
            string str = "";
            str += name;
            return str;
        }
        public virtual string GetInfo()
        {
            string str = "";
            str += name+"\r\n";
            str += "Level " + level.ToString() + "\r\n";
            foreach(absResource r in res)
            {
                str += r.name + " " + r.count.ToString();
            }
            str += "\r\n";
            return str;
        }

    }
}

//инкапсуляция, паттерн стратегии, паттерн команда
