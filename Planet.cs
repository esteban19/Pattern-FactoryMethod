using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    //<<interface>> or abstract class
    //   Product
    public abstract class Planet
    {
        private string name;
        private int distance;

        public string Name
        {
            get { return name; }
            set { name = value;  }
        }
        //public string getName() { return name; }
        //public void setName(string newname) { name = newname; }

        public int Distance
        {
            get { return distance; }
            set { distance = value; }
        }

        public void planetName()
        {
            Console.WriteLine("Name of planet: {0}", Name);
        }
        public void distanceToEarth()
        {
            Console.WriteLine("Distance to Earth: {0}mi", Distance);
        }

    }
}
