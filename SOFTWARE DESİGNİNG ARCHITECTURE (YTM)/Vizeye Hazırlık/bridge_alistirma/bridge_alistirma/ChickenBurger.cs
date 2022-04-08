using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge_alistirma
{
    class ChickenBurger : Burger
    {
        public ChickenBurger()
        {
            _wrapper.name = "Non Veg Burger";
            _wrapper.price = 15;
        }
    }
}
