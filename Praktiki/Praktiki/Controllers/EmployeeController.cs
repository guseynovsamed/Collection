using Service.Services;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiki.Controllers
{
    internal class EmployeeController
    {
        private IEmployeeService _employeeService;
        public EmployeeController()
        {
            _employeeService = new EmployeeService();
        }

        public void GetCountByFilter()
        {
            decimal salary = 1200;
            DateTime start = new(2000, 01, 01);
            DateTime end = new(2010, 01, 01);
            var result = _employeeService.GetAllBySalary(start, end, salary);

            Console.WriteLine(result);
        }
    }
}
