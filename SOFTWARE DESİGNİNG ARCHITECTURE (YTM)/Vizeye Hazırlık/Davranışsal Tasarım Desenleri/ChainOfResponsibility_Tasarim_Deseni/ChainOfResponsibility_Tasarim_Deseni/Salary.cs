using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Tasarim_Deseni
{
    public class Salary : CreditControl
    {
        public override void Control(Customer customer)
        {
            if (base.isConfirmed != false)
            {
                if (customer.guarantor)
                    base.isConfirmed = true;
                else
                    base.isConfirmed = false;
            }
        }
    }
}
