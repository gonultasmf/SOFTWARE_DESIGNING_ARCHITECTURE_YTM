using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Tasarim_Deseni
{
    public class Customer
    {
        public int scor;
        public int delay;
        public bool guarantor;
        public bool salary;

        public Customer(int scor, int delay, bool guarantor, bool salary)
        {
            this.scor = scor;
            this.delay = delay;
            this.guarantor = guarantor;
            this.salary = salary;
        }
    }
}
