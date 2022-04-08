using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Tasarım_Deseni
{
    interface IDatabase
    {
        void dbQuery(string TC);
    }
}
