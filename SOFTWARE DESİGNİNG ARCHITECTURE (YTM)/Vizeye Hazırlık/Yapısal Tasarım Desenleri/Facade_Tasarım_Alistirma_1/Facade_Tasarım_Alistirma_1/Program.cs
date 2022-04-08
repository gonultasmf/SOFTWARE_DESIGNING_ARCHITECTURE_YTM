using System;

namespace Facade_Tasarım_Alistirma_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();

            Customer customer1 = new Customer()
            {
                IDNo = "12356789",
                FullName = "Ahmet",
                CustomerNumber = 123456,
                CashAmount = 3452652.25M
            };
            Customer customer2 = new Customer()
            {
                IDNo = "97654321",
                FullName = "Mehmet",
                CustomerNumber = 654321,
                CashAmount = 635947.15M
            };

            facade.SendEFT(customer1, customer2, 123456);

            facade.UseCredit(customer2);

            Console.ReadLine();
        }
    }
}
