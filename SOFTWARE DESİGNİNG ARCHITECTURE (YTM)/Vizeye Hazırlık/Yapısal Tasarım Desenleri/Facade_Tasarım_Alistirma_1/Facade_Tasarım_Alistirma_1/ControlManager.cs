using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Tasarım_Alistirma_1
{
    public static class ControlManager
    {
        public static bool CheckHasEnoughCashInBankAccount(Customer customer, decimal amount)
        {
            if (customer.CashAmount >= amount)
                return true;
            else
                return false;
        }
        public static bool CheckCanUseCredit(string IDNo)
        {
            return true;
        }
    }
}
