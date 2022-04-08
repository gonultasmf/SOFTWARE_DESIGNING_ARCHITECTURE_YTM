using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Tasarım_Deseni
{
    class ExcelFormat : IFormat
    {
        public void Olustur()
        {
            Console.WriteLine("EXCEL formatında oluşturuldu...");
        }
    }
}
