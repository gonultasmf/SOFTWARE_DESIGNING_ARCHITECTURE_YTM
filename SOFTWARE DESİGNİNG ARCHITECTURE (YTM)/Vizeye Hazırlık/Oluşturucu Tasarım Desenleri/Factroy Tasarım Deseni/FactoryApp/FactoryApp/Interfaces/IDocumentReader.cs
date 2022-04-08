using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryApp
{
    interface IDocumentReader
    {
        void Read();
        void Extract();
    }
}
