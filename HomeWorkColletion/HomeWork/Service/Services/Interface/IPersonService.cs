using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interface
{
    public interface IPersonService
    {
        public void Add(Person person);
        public List<Person> GetAll();
        public void Delete(Person person);
        public List<Person> Search(string text);
    }
}
