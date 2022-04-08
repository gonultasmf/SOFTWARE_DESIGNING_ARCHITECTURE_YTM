using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge_alistirma
{
    class Meal
    {
        private List<Item> items;
        public Meal()
        {
            items = new List<Item>();
        }
        public void addItem(Item item)
        {
            items.Add(item);
        }
        public float getCost()
        {
            float result = 0;
            foreach (Item item in items)
            {
                result += item.price();
            }
            return result;
        }
        public void showItems()
        {
            foreach (Item item in items)
            {
                Console.WriteLine(item.name() + " is price : " + item.price());
            }
        }
    }
}
