using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Tasarim_Deseni
{
    public class PayDelay : CreditControl
    {
        public override void Control(Customer customer)
        {
            if (base.isConfirmed != false)
            {
                if (customer.delay < 3)
                    base.isConfirmed = true;
                else
                    base.isConfirmed = false;
            }
        }
    }
}
