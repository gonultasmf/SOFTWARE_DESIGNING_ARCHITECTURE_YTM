using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Tasarım_Deseni
{
    class Car : IProduct
    {
        public int Model; 
        public Car(string name, decimal price, int Model) : base(name, price)
        {
            this.Model = Model;
        }
    }
}
