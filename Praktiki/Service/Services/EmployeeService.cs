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
    public class EmployeeService : IEmployeeService
    {
        public int GetAllBySalary(DateTime star, DateTime end, decimal salary)
        {
            return AppDbContext.Employees().Where(n => n.Birthday > star && n.Birthday < end && n.Salary > salary).Count();
        }
    }
}
