using Domain.Models;
using Service.Data;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class PersonService : IPersonService
    {
        public List<Person> GetAll()
        {
            return AppDbContext.people;
        }
        public void Add(Person person)
        {
            AppDbContext.people.Add(person);
        }
        public void Delete(Person person)
        {
            AppDbContext.people.Remove(person);
        }
        public List<Person> Search(string text)
        {
           return AppDbContext.people.Where(x=>x.Name.Contains(text.ToLower().Trim().ToUpper()) || x.Surname.Contains(text.ToLower().Trim().ToUpper())).ToList();
        }
    }
}
