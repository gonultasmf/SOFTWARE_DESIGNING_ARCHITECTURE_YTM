using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Tasarım_Deseni
{
    public abstract class IProduct
    {
        public List<Customer> MyList = new List<Customer>();
        public string ProductName { get; set; }
        private decimal _ProductPrice;

        public IProduct(string name, decimal price)
        {
            this.ProductName = name;
            this._ProductPrice = price;
        }
        public void Add(Customer customer)
        {
            MyList.Add(customer);
        }
        public void Delete(Customer customer)
        {
            MyList.Remove(customer);
        }
        public void NotifyObserver()
        {
            foreach (Customer item in MyList)
            {
                item.Update(this);
            }
        }

        public decimal Price
        {
            get 
            {
                return _ProductPrice; 
            }
            set
            {
                if (_ProductPrice/2 >= value)
                {
                    NotifyObserver();
                }
                _ProductPrice = value;
            }
        }

    }
}
