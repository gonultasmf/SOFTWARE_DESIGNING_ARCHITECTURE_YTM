using System;

namespace Lab_Ders_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Factory sınıfının bir amacıda kohezyın ve bağlaşımı yapmaktır. bağlaşımı düşürmek ve kohezyonu da artırmak için de yapılır.
            Console.WriteLine("Factory");

            //Zip zip = new Zip(".zip");
            //Rar rar = new Rar("Rar/");

            string file = "Desktop/Homework.doc";

            //zip.compString(file);
            

            Factory factory = new Factory();
            
            factory.SikistirmaTipi("rar").compString(file);
            factory.SikistirmaTipi("zip").compString(file);

            /*IDosyaSikistirma rar = factory.SikistirmaTipi("rar");
            rar.compString(file);
            */
        }
    }
}
