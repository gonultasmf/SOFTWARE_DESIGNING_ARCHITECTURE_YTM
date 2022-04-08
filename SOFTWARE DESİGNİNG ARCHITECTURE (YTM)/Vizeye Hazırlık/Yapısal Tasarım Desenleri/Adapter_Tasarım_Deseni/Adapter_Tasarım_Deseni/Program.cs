using System;

namespace Adapter_Tasarım_Deseni
{
    class Program
    {
        static void Main(string[] args)
        {
            IDatabase database = new SqlDB("");
            database.dbQuery("1254354");
            database = new Adapter("Mustafa");
            database.dbQuery("545456435");
        }
    }
}
