using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge_alistirma
{
    class Coke : ColdDrink
    {
        public Coke()
        {
            _bottle.name = "Coke";
            _bottle.price = 8;
        }
    }
}
