using GameBank.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GameBank.Repository
{
    internal interface IBankRepository
    {
        Bank createBank(Bank bank);
        Bank getBankById(int id);
        Bank updateBank(int id, Bank bank);
        void deleteBank(int id);

        Bank getBankByNumber(string number);

        Bank[] findBankByUserName(string username);
        
    }
}
