using Praktiki.Exceptions;
using Service.Services;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiki.Controllers
{
    public class AuthorController
    {
        private IAuthorService _authorService;
        public AuthorController()
        {
            _authorService = new AuthorService();
        }
        public void GetAllByAge()
        {
            try
            {
                
                
                Console.WriteLine("Please enter age:");
                byte age = Convert.ToByte(Console.ReadLine());
                var result = _authorService.GetAllByAge(age);

                if(age == 0)
                {
                    throw new CustomException();
                }

                foreach (var item in result)
                {
                    var show = $"{item.Name}-{item.Surname}-{item.Age}";
                    Console.WriteLine(show);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }




    }

}
