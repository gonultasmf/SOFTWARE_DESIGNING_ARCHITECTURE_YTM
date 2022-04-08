using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Tasarım_Deseni
{
    public abstract class Customer
    {
        public string Name { get; set; }
        public List<IProduct> MyFavourite = new List<IProduct>();
        public Customer(string name)
        {
            this.Name = name;
        }
        public void AddFavourite(IProduct product)
        {
            MyFavourite.Add(product);
            product.Add(this);
        }
        public void DeleteFavourite(IProduct product)
        {
            MyFavourite.Remove(product);
            product.Delete(this);
        }
        public void ShowFavourites()
        {
            Console.WriteLine(Name + " müşterisinin Favori Listesi :");
            foreach (IProduct item in MyFavourite)
            {
                Console.WriteLine(item.ProductName + " : " + item.Price);
            }
        }
        public void Update(IProduct product)
        {
            Console.WriteLine(Name + " adlı müşterinin " + product.ProductName +
                " ürününün fiyatı " + product.Price + " olarak değişti");
        }

    }
}
