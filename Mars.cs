using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    // ConcreteProduct
    public class Mars : Planet 
    {
        public Mars() 
        {
            Name = "Mars";
            Distance = 223524393;
        }

    }
}
