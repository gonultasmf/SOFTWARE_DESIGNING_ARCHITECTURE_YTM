using System;

namespace Observer_Tasarım_Deseni
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer1("Mustafa");
            Customer customer2 = new Customer2("Furkan");
            IProduct shoes = new Shoes("Ayakkabı", 150);
            IProduct car = new Car("Volvo", 2500000, 2020);
            IProduct pc = new Computer("Monster", 28000, "Tulpar T7");
            car.Add(customer1);
            customer1.AddFavourite(shoes);
            customer1.AddFavourite(car);
            customer1.AddFavourite(pc);
            customer2.AddFavourite(shoes);
            customer2.AddFavourite(pc);
            shoes.Price = 75;
            car.Price = 1200000;
            customer1.ShowFavourites();
            customer2.ShowFavourites();
        }
    }
}
