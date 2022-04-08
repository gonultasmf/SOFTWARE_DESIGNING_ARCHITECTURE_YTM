using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_App.DataBase
{
    public class DataBase
    {
        private static DataBase db;
        private static Object obj = new Object();
        private DBFactory _dbFactory;
        private DataBase(DBFactory dbFactory) 
        {
            this._dbFactory = dbFactory;
            Connection conn = dbFactory.CreateConn();
            conn.Connect();
            Command cmd = dbFactory.CreateComm();
            cmd.Execute();
        }

        public static DataBase GetDB(DBFactory dbFactory)
        {
            if (db == null)
            {
                lock (obj)
                {
                    if (db == null)
                        db = new DataBase(dbFactory);
                }
            }
            return db;
        }
    }
}
