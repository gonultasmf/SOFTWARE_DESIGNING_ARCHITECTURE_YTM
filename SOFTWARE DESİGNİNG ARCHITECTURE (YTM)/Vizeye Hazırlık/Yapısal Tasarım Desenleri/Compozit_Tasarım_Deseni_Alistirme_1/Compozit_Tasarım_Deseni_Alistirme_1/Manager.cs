using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compozit_Tasarım_Deseni_Alistirme_1
{
    public class Manager : IWorker
    {
        private int _id;
        private string _isim;

        public string Isim { get => _isim; set => _isim = value; }
        public int Id { get => _id; set => _id = value; }

        public Manager(int id, string isim)
        {
            Id = id;
            Isim = isim;
        }

        public void bilgiGoster()
        {
            Console.WriteLine("The name of the manager number {0} is {1}", Id, Isim);
        }
    }
}
