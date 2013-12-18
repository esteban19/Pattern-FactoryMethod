using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    /* Factory Pattern in action */
    //  ConcreteCreator
    //  +factoryMethod() i.e. +makePlanet()
    /* Move all decision making into this new class*/
    public class PlanetFactory
    {
        public Planet makePlanet(string newPlanetType)
        {
            //Planet newPlanet = null;
            if (newPlanetType == "V")
            {
                return new Venus();
            }
            else if (newPlanetType == "M")
            {
                return new Mars();
            }
            else if (newPlanetType == "P")
            {
                return new Phobos();
            }
            else return null;
        }
    }
}
