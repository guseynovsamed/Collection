using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiki.Exceptions
{
    public class CustomException : Exception
    {
        public CustomException() : this("Age 0 ola bilmez")
        {
            
        }
        public CustomException(string msj): base(msj)
        {
            
        }

    }
}
