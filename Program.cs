using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creator
            PlanetFactory planetfctry = new PlanetFactory();
            Planet thePlanet = null;

            Console.WriteLine("Do you want V for Venus, M for Mars, or P for Phobos?");
            string option;
            do
            {
                option = Console.ReadLine();
            } while (option == null);

            //+factoryMethod() i.e. makePlanet(option)
            thePlanet = planetfctry.makePlanet(option);

            //+anOperation() i.e. doActions(thePlanet)
            if (thePlanet != null)
                doActions(thePlanet);
            else
                Console.WriteLine("You didn't enter an appropriate value.");

        }

        private static void doActions(Planet planet)
        {
            planet.planetName();
            planet.distanceToEarth();
        }
    }
}
/*Moved to Planet Factory
 * 
 * 
 * 
 *             string option;
            do
            {
                option = Console.ReadLine();
            } while (option == null);

            //Replace this with factory pattern
            if (option == "M")
            { thePlanet = new Mars(); }
            else if (option.Equals("V"))
            { thePlanet = new Venus();  }
 * 
*/