using System;
using System.Collections.Generic;

namespace ChainOfResponsibility_Tasarim_Deseni
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CreditControl> list = new List<CreditControl>();

            list.Add(new CreditScor());
            list.Add(new PayDelay());
            list.Add(new Guarantor());
            list.Add(new Salary());

            list[0].setNextControl(list[1]);
            list[1].setNextControl(list[2]);
            list[2].setNextControl(list[3]);
            list[3].setNextControl(null);

            list[0].Control(new Customer(1600, 2, true, true));

            bool isConfirmed = list[list.Count - 1].isConfirmed;

            if(isConfirmed)
                Console.WriteLine("Kredi Onaylandı");
            else
                Console.WriteLine("Kredi Onaylanmadı");
        }
    }
}
