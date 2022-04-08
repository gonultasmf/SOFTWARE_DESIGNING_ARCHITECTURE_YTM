using System;

namespace Abstract_Factory_App
{
    public class SQLConnection : Connection
    {
        public override string ConnString { 
            get 
            {
                return ConnString;
            }
            set 
            { 

            }
        }

        public override void Connect()
        {
            Console.WriteLine("SQL Bağlantı Kuruldu...");
        }
    }
}
