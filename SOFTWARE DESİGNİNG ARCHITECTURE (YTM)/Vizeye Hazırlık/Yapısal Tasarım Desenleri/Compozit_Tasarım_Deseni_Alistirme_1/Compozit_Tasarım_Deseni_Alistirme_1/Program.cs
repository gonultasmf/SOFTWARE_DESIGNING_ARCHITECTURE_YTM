using System;
using System.Collections.Generic;

namespace Compozit_Tasarım_Deseni_Alistirme_1
{

    class Program
    {
        static void Main(string[] args)
        {

            HumanResources hResources = new HumanResources();
            HumanResources hResources1 = new HumanResources();
            IWorker designer = new Designer(25, "Fatma");
            IWorker developer = new Developer(44, "Mustafa");
            IWorker manager = new Manager(34, "Gönültaş");

            hResources.AddWorker(designer);
            hResources.AddWorker(developer);
            hResources.AddWorker(manager);
            hResources1.AddWorker(hResources);
            hResources1.AddWorker(manager);

            hResources.bilgiGoster();

            Console.WriteLine("_________________________________________________\n");

            hResources.DeleteWorker(manager);
            hResources.bilgiGoster();

            Console.WriteLine("_________________________________________________\n");

            hResources1.bilgiGoster();
        }
    }

}
