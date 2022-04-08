using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Deseni
{
    class Klima
    {
        public int sicaklik { get; set; }

        public void Guncelle(int value)
        {
            sicaklik = value;
        }
        public void Ac() 
        {
            Console.WriteLine("Klima Açıldı...");
        }
        public void Kapat() 
        {
            Console.WriteLine("Klima Kapandı...");
        }
    }
}
