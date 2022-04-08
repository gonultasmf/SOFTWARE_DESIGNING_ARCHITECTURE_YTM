using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Tasarım_Alistirma_1
{
    public class EFTManager
    {
        public void SendEFT(Customer fromCustomer, Customer toCustomer, decimal eftAmount)
        {
            if (ControlManager.CheckHasEnoughCashInBankAccount(fromCustomer, eftAmount))
            {
                fromCustomer.CashAmount -= eftAmount;
                Console.WriteLine("Sent to account " + toCustomer.CustomerNumber + " via EFT...");
            }
            else
                Console.WriteLine("Insufficient balance. EFT transaction failed...");
        }
    }
}
