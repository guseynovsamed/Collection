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
        public static List<Person> people;

        static AppDbContext()
        {
            people = new List<Person>()
            {
                new Person() {Name = "Ilham" , Surname = "Abasli" , Phone = "0552221100" , Id = 1 },
                new Person() {Name = "Aqsin" , Surname = "Veliyev" , Phone = "0502346655" , Id = 2 },
                new Person() {Name = "Rufet" , Surname = "Meherremli" , Phone = "0516889977" , Id = 3 },
                new Person() {Name = "Tural" , Surname = "Xelilov" , Phone = "0558880033", Id = 4 },
                new Person() {Name = "Semed" , Surname = "Huseynov" , Phone = "0553880000", Id = 5 }
            };
        }
    }
}
