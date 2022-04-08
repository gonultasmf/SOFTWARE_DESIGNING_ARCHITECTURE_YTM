using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility_Tasarim_Deseni
{
    public abstract class CreditControl
    {
        public bool isConfirmed = true;
        protected CreditControl nextCreditControl;
        public void setNextControl(CreditControl creditControl)
        {
            this.nextCreditControl = creditControl;
        }
        public void Execute(Customer customer)
        {
            Control(customer);
            if (this.nextCreditControl == null)
            {
                this.nextCreditControl.isConfirmed = this.isConfirmed;
                this.nextCreditControl.Execute(customer);
            }
        }
        public abstract void Control(Customer customer);
    }
}
