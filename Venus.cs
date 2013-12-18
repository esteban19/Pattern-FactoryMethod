using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{   
    // ConcreteProduct
    class Venus : Planet
    {
        public Venus()
        {
            Name = "Venus";
            Distance = 38000000;
        }
    }
}
