using GameBank.model;
using GameBank.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBank.Services
{
    internal interface IAuthService
    {
        Player registration(string login, string pass, string confirmPass);
        Player login(string login, string pass);
        Player checkSession();
    }
}
