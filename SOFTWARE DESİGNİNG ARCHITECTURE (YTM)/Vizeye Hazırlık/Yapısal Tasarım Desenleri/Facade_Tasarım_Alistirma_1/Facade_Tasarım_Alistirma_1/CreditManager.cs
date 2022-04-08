using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Tasarım_Alistirma_1
{
    public class CreditManager
    {
        public void UseCredit(Customer customer)
        {
            if (ControlManager.CheckCanUseCredit(customer.IDNo))
                Console.WriteLine("Credit has been made.");
            else
                Console.WriteLine("Your bank loan has not been approved.");
        }
    }
}
