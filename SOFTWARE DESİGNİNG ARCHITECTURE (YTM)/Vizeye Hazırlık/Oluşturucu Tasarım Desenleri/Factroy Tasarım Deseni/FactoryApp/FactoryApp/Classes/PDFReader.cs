using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp.Classes
{
    class PDFReader : IDocumentReader
    {
        public void Extract()
        {
            Console.WriteLine("PDF Extract....");
        }

        public void Read()
        {
            Console.WriteLine("PDF Reader....");
        }
    }
}
