using Domain.Models;
using Service.Data;
using Service.Services;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Controllers
{
    public class PersonController
    {
        private IPersonService _personService;
        public PersonController()
        {
            _personService = new PersonService();
        }
        public void Add()
        {
            Console.WriteLine("Name");
            string name = Console.ReadLine();
            Console.WriteLine("Surname");
            string surname = Console.ReadLine();
            Console.WriteLine("Phone");
            string phone = Console.ReadLine();
            Person person = new Person()
            {
                Name = name,
                Surname = surname,
                Phone = phone
            };
            _personService.Add(person);
        }
        public void Delete()
        {
           
            Console.WriteLine("Enter Name for delet contact");
            var people = _personService.GetAll();
            foreach(Person item in people)
            {
                Console.WriteLine(item.Name+" "+item.Surname+" "+item.Phone);
            }
            string name = Console.ReadLine();
            var person = people.Find(x => x.Name == name);
            _personService.Delete(person);
        }
        public void ShowPersonInfo()
        {
            var result = _personService.GetAll();
            foreach (var item in result)
            {
                Console.WriteLine(item.Name + " " + item.Surname + " " + item.Phone + " " + item.Id);
            }
        }

        public void Search()
        {
            Console.WriteLine("Please enter search text");
            string text = Console.ReadLine();
            var resp = _personService.Search(text);
            foreach (var item in resp)
            {
                Console.WriteLine(item.Name+" "+item.Surname+" "+item.Phone);
            }
        }



    }
}
