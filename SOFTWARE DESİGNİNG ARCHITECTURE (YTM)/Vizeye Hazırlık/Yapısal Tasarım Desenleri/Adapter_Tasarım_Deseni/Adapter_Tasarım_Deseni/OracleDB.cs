using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Tasarım_Deseni
{
    class OracleDB
    {
        private string connString;
        public OracleDB(string connectionString)
        {
            this.connString = connectionString;
        }
        public void dbQuery(string TC, string ad)
        {
            Console.WriteLine(TC + " " + ad + " Oracle'de sorgulandı...");
        }
    }
}
