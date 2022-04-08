using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SozlukApp
{
    interface IDBService
    {
        void Connection(string connString);
        List<string> Search(string word);
    }
}
