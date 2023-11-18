using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public  class Account : BaseEntity
    {
        public string Usernama { get; set; }
        public string Password { get; set; }
    }
}
