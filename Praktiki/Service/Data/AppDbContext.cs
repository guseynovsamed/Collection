using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Data
{
    public static class AppDbContext
    {
        public static List<Author> Authors()
        {
            return new List<Author>()
            {
                new Author{Name = "Ilham" , Surname="Abasli", Age = 21 , Id = 1},
                new Author{Name = "Aqsin" , Surname="Veliyev", Age = 24 , Id = 2},
                new Author{Name = "Semed" , Surname="Huseynov", Age = 26 , Id = 3},
                new Author{Name = "Haci" , Surname="Abbasli", Age = 28 , Id = 4}
            };
        }
        public static List<Employee> Employees()
        {
            return new List<Employee>()
            {
                new Employee{Name = "Ilham" , Surname = "Abasli" , Salary = 120 , Birthday = new (2001 ,01 , 01)  , Id = 1},
                new Employee{Name = "Aqsin" , Surname = "Veliyev" , Salary = 1720 , Birthday = new (1998 ,01 , 01)  , Id = 2},
                new Employee{Name = "Semed" , Surname = "Huseynov" , Salary = 1220 , Birthday = new (2007 ,01 , 01)  , Id = 3}

            };
        }
        public static List<Account> Accounts()
        {
            return new List<Account>
            {
                new Account { Usernama = "SemedHuseyn", Password = "12345", Id = 1 },
                new Account { Usernama = "TunzaleMamed", Password = "1234T", Id = 2 },
            };
        }
        public static List<Product> Products()
        {
            return new List<Product>()
            {
                new Product{Name = "Iphone" , Price = 2500 , Count = 12 , Id = 1},
                new Product{Name = "Samsung" , Price = 1500 , Count = 2 , Id = 2},
                new Product{Name = "Sony" , Price = 200 , Count = 42 , Id = 3},
                new Product{Name = "Bosch" , Price = 5500 , Count = 82 , Id = 4},
            };
        }
    }
}
