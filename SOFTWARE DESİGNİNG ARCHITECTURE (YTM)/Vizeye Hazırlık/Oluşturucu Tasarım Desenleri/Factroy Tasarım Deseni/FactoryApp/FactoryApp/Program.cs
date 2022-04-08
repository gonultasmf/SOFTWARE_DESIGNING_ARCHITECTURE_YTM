using FactoryApp.Classes;
using FactoryApp.Factory_Classes;
using System;

namespace FactoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //______________________________________//
            /////////// YALIN STATİK YAPI ////////////
            //**************************************//
            // 1. Kullanım
            /*
            DocumentReaderFactory readerFactory = new DocumentReaderFactory();
            IDocumentReader pdfReader = (PDFReader)readerFactory.Get("PDF");
            pdfReader.Read();
            pdfReader.Extract();
            */


            // 1.1 Kullanım generic version

            IDocumentReader pdfReader1 = DocumentFactory<PDFReader>.Get();
            IDocumentReader wordReader1 = DocumentFactory<WordReader>.Get();

            pdfReader1.Read();
            pdfReader1.Extract();
            wordReader1.Read();
            wordReader1.Extract();




            //_________________________________________//
            /////////// KAPSAMLI STATİK YAPI ////////////
            //*****************************************//

            // 2. Kullanım 

            DocumentReader readerFactory = new DocumentReader();
            PDFReader pdfReader2 = (PDFReader)readerFactory.Get(new PDFReaderFactory());
            pdfReader2.Read();
            pdfReader2.Extract();


            // 2.1 Kullanım generic

            DocumentReaderPro readerPro = new DocumentReaderPro();
            readerPro.Process(new PDFReaderFactory());

        }
    }
}
