using FactoryApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp
{
    class PDFReaderFactory : IDocumentReaderFactroy
    {
        public IDocumentReader CreateReader()
        {
            return new PDFReader();
        }
    }
}
