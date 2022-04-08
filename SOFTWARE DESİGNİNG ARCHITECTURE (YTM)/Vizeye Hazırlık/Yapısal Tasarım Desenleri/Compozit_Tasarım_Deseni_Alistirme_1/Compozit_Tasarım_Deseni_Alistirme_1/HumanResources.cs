using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compozit_Tasarım_Deseni_Alistirme_1
{
    public class HumanResources : IWorker
    {
        private List<IWorker> workerList;

        public HumanResources()
        {
            workerList = new List<IWorker>();
        }

        public void bilgiGoster()
        {
            foreach (IWorker item in workerList)
            {
                item.bilgiGoster();
            }
        }

        public void AddWorker(IWorker worker)
        {
            workerList.Add(worker);
        }

        public void DeleteWorker(IWorker worker)
        {
            workerList.Remove(worker);
        }
    }
}
