using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Tasarım_Deseni
{
    abstract class Rapor
    {
        public IFormat format { get; set; }
        public Rapor()
        {

        }
        public Rapor(IFormat format)
        {
            this.format = format;
        }
        public abstract void Goster();
    }
}
