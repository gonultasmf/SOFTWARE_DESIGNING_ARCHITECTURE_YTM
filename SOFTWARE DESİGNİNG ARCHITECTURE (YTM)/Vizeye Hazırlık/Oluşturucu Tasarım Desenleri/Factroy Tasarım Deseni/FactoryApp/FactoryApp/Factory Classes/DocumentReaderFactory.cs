using FactoryApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp.Factory_Classes
{
    //private static IDocumentReader opr = null;
    // 1. Kullanım class'ı
    class DocumentReaderFactory
    {
        public IDocumentReader Get(string readerType)
        {
            switch (readerType)
            {
                case "PDF":
                    return new PDFReader();
                case "Word":
                    return new WordReader();
                default:
                    return new PDFReader();
            }
        }
    }

    // 1.1 Kullanım Generic version
    class DocumentFactory<T> where T : IDocumentReader, new()
    {
        private static IDocumentReader opr = null;

        public static IDocumentReader Get()
        {
            return opr = new T();
        }
    }

    // 2. Kullanım
    class DocumentReader
    {
        public IDocumentReader Get(IDocumentReaderFactroy factroy)
        {
            return factroy.CreateReader();
        }
    }

    // 2.1 Kullanım generic
    class DocumentReaderPro
    {
        public void Process(IDocumentReaderFactroy factroy)
        {
            IDocumentReader reader = factroy.CreateReader();
            reader.Read();
            reader.Extract();
        }
    }
}
