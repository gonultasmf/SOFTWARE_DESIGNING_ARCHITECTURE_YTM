using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge_alistirma
{
    public abstract class Item
    {
        public abstract string name();
        public abstract Packing packing();
        public abstract float price();
    }
}
