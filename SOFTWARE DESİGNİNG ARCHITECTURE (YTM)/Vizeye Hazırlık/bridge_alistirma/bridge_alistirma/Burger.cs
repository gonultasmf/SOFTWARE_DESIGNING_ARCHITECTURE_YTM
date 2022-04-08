using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge_alistirma
{
    class Burger : Item
    {
        protected Wrapper _wrapper;
        public Burger()
        {
             _wrapper = new Wrapper();
        }
        public override string name()
        {
            return _wrapper.name;
        }

        public override Packing packing()
        {
            throw new NotImplementedException();
        }

        public override float price()
        {
            return _wrapper.price;
        }
    }
}
