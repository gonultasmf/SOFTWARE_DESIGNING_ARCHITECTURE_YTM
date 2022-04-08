using System;

namespace Lab_Ders_1
{
    class Program
    {
        static void Main(string[] args)
        {
            YukDengeleyici yd1 = YukDengeleyici.GetYukDengeleyici();
            YukDengeleyici yd2 = YukDengeleyici.GetYukDengeleyici();
            YukDengeleyici yd3 = YukDengeleyici.GetYukDengeleyici();
            YukDengeleyici yd4 = YukDengeleyici.GetYukDengeleyici();
            if (yd1 == yd2 && yd2 == yd3 && yd3 == yd4)
            {
                Console.WriteLine("Aynı yük dengeliyicilerdir.\n" + yd1.Sunucu() + "\n"+
                    yd2.Sunucu() + "\n" + yd3.Sunucu() + "\n" + yd4.Sunucu() + " sunucusu çalıştı...");
            }
        }
    }
}
