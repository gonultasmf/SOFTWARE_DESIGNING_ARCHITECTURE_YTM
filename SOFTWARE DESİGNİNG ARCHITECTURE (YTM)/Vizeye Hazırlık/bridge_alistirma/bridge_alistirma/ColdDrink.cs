using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge_alistirma
{
    class ColdDrink : Item
    {
        protected Bottle _bottle;
        public ColdDrink()
        {
            _bottle = new Bottle();
        }
        public override string name()
        {
            return _bottle.name;
        }

        public override Packing packing()
        {
            throw new NotImplementedException();
        }

        public override float price()
        {
            return _bottle.price;
        }
    }
}
