using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Tasarım_Alistirma_1
{
    public class Facade
    {

        private EFTManager _eftManager;
        private CreditManager _creditmanager;

        public Facade()
        {
            _eftManager = new EFTManager();
            _creditmanager = new CreditManager();
        }


        public void SendEFT(Customer fromCustomer, Customer toCustomer, decimal eftAmount)
        {
            _eftManager.SendEFT(fromCustomer, toCustomer, eftAmount);
        }

        public void UseCredit(Customer customer)
        {
            _creditmanager.UseCredit(customer);
        }
    }
}
