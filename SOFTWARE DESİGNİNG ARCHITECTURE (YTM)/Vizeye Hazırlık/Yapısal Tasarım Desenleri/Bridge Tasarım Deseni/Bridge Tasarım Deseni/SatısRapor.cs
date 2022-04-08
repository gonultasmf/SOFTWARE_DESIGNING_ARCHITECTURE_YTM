using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Tasarım_Deseni
{
    class SatısRapor : Rapor
    {
        public SatısRapor(IFormat format) : base(format)
        {
        }
        public override void Goster() 
        {
            base.format.Olustur();
            Console.WriteLine("Satış Raporu Gösterildi...");
        }
    }
}
