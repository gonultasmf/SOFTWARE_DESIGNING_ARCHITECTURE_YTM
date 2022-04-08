using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp.Classes
{
    class WordReader : IDocumentReader
    {
        public void Extract()
        {
            Console.WriteLine("Word Extract....");
        }

        public void Read()
        {
            Console.WriteLine("Word Reader....");
        }
    }
}
