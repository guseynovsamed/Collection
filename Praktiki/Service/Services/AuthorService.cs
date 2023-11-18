using Domain.Models;
using Service.Data;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class AuthorService : IAuthorService
    {
        public List<Author> GetAllByAge(byte age)
        {
            return AppDbContext.Authors().FindAll(x => x.Age > age);
        }
    }
}
