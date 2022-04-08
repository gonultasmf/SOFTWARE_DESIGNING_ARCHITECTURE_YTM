using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Deseni
{
    class Televizyon
    {
        public int sesSeviye { get; set; }
        public int kanalNumara { get; set; }
        public Televizyon()
        {
            sesSeviye = 0;
            kanalNumara = 0;
        }
        public void Ac()
        {
            Console.WriteLine("Klima Açıldı...");
        }
        public void Kapat()
        {
            Console.WriteLine("Klima Kapandı...");
        }
        public void sesAzalt() 
        {
            sesSeviye--;
        }
        public void sesArttir()
        {
            sesSeviye++;
        }
        public void kanalAzalt()
        {
            kanalNumara--;
        }
        public void kanalArttir()
        {
            kanalNumara++;
        }
    }
}
