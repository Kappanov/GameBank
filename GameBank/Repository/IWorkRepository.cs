using GameBank.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBank.Repository
{
    internal interface IWorkRepository
    {
        Work[] getAllWork();
        Work[] accessWorks(int level);

        Work getWorkById(int id);

        Work createWork(Work work);

        Work updateWorkId(int id, Work updatedWork);

        void deleteWorkById(int id);

    }
}
