using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Ders_1
{
    class YukDengeleyici
    {
        private static YukDengeleyici nesne;
        private List<string> sunucular = new List<string>();
        private Random rnd = new Random();

        protected YukDengeleyici()
        {
            sunucular.Add("Sunucu_1");
            sunucular.Add("Sunucu_2");
            sunucular.Add("Sunucu_3");
            sunucular.Add("Sunucu_4");
            sunucular.Add("Sunucu_5");
        }
        public static YukDengeleyici GetYukDengeleyici()
        {
            if (nesne == null)
            {
                nesne = new YukDengeleyici();
            }
            return nesne;
        }
        public string Sunucu()
        {
            return sunucular[rnd.Next(sunucular.Count)];
        }
    }
}
