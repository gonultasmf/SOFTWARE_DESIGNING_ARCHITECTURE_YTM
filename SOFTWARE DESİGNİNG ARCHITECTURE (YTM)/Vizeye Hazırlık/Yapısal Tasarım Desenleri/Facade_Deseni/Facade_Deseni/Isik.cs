using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Deseni
{
    class Isik
    {
        public bool[] durum;

        public Isik(int value)
        {
            durum = new bool[value];
        }
        public void Ac(int value) 
        {
            durum[value] = true;
            Console.WriteLine(value + ". Işık açıldı...");
        }
        public void Kapat(int value)
        {
            durum[value] = false;
            Console.WriteLine(value + ". Işık kapandı...");
        }

    }
}
