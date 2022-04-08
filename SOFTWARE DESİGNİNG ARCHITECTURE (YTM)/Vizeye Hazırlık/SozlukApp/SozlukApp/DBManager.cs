using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SozlukApp
{
    class DBManager
    {
        IDBService _dBService;
        string _connString;
        public DBManager(IDBService dBService, string connString)
        {
            dBService.Connection(connString);
            _dBService = dBService;

        }
         public List<string> Search(string word)
         {
            return _dBService.Search(word);
         }
    }
}
