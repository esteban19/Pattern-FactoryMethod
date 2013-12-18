using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    // ConcreteProduct
    //a moon of Mars, a sort of planet
    public class Phobos : Mars
    {
        public Phobos()
        {
            Name = "Phobos";
            Distance = 240524393;
        }
    }
}
