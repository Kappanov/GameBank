using GameBank.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBank.Services
{
    internal interface IPlayerService
    {
        Player changeName(string newName);
        Player changePassword(string newPass);
        Player changeWork(IWorkService newWork);
        Player quitWork();
        Player getStatistic();

        Player createBank();

    }
}
