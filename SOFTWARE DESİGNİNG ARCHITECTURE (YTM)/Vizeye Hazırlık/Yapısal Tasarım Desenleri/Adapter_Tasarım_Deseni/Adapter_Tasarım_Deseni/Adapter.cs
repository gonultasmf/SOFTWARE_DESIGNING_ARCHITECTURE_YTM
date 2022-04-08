using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Tasarım_Deseni
{
    class Adapter : IDatabase
    {
        string ad;
        OracleDB oracle;
        public Adapter(string ad)
        {
            this.ad = ad;
            oracle = new OracleDB("");
        }
        public void dbQuery(string TC)
        {
            oracle.dbQuery(TC, ad);
        }
    }
}
