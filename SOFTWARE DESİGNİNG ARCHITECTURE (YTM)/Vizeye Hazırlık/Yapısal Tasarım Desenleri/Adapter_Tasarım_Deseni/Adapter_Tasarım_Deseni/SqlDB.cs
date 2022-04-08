using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Tasarım_Deseni
{
    class SqlDB : IDatabase
    {
        private string connString;
        public SqlDB(string connectionString)
        {
            this.connString = connectionString;
        }
        public void dbQuery(string TC) 
        {
            Console.WriteLine(TC + " Sql'de sorgulandı...");
        }
    }
}
