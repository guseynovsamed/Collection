using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interface
{
    public interface IEmployeeService
    {
        int GetAllBySalary(DateTime star, DateTime end, decimal salary);
    }
}
