using Service.Services;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiki.Controllers
{
    public class AccountContoller
    {
        private IAccountService _accountService;
        public AccountContoller()
        {
            _accountService = new AccountService();
        }
        public bool Login()
        {
            Console.WriteLine("Please enter username:");
            Start: string username = Console.ReadLine();
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            var respons =  _accountService.Login(username, password);

            if (!respons)
            {
                Console.WriteLine("Email or password is wrong \n Please enter inputs again ");
                goto Start;
            }

            return true;

        }
    }
}
