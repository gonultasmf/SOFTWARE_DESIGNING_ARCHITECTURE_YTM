using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge_alistirma
{
    class VegBurger : Burger
    {
        public VegBurger()
        {
            _wrapper.name = "Veg Burger";
            _wrapper.price = 10;
        }
    }
}
