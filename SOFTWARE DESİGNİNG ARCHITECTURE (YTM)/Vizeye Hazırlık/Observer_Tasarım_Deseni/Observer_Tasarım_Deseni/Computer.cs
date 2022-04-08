using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Tasarım_Deseni
{
    class Computer : IProduct
    {
        public string Marka;
        public Computer(string name, decimal price, string Marka) : base(name, price)
        {
            this.Marka = Marka;
        }
    }
}
