using GameBank.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBank.Services
{
    internal interface IBankService
    {
        Bank createAccount();
        void getMoney(int count,int bankNumber);
        void addMoney(int count,int bankNumber);

    }
}
