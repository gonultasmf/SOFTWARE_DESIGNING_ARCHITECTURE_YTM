using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Tasarim_Deseni
{
    class CreditScor : CreditControl
    {
        public override void Control(Customer customer)
        {
            if (base.isConfirmed != false)
            {
                if (customer.scor >= 1500)
                    base.isConfirmed = true;
                else
                    base.isConfirmed = false;
            }
        }
    }
}
