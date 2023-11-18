using Service.Data;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class AccountService : IAccountService
    {
        public bool Login(string userName, string password)
        {
            return AppDbContext.Accounts().Exists(n => n.Usernama == userName && n.Password == password);
        }
    }
}
