using System;

namespace Bridge_Tasarım_Deseni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bridge Tasarım Deseni\n");
            Rapor rapor = new IsciRapor(new PdfFormat());
            Rapor rapor1 = new SatısRapor(new ExcelFormat());
            rapor.Goster();
            rapor1.Goster();
            rapor.format = new ExcelFormat();
            rapor.Goster();
        }
    }
}
