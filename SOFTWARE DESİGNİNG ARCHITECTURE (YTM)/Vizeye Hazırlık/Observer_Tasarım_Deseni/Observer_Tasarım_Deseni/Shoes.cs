using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Tasarım_Deseni
{
    public class Shoes : IProduct
    {
        public Shoes(string name, decimal price) : base(name, price)
        {
        }
    }
}
