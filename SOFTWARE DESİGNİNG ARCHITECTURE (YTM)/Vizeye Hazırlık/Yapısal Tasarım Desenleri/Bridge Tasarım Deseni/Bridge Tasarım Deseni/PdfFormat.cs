using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Tasarım_Deseni
{
    class PdfFormat : IFormat
    {
        public void Olustur()
        {
            Console.WriteLine("PDF formatında oluşturuldu...");
        }
    }
}
