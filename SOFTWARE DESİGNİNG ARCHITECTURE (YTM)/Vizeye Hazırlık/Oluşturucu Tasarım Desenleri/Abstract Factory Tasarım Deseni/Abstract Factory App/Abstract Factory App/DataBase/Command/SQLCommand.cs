using System;

namespace Abstract_Factory_App
{
    public class SQLCommand : Command
    {
        public override string Query 
        {
            get 
            {
                return Query;
            } 
            set
            {
                Query = value;
            }
        }

        public override void Execute()
        {
            Console.WriteLine("SQL Komudu Çalıştı...");
        }
    }
}
