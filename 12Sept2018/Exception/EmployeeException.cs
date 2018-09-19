using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Sept2018.ExceptionDemo
{
    class EmployeeException : ApplicationException
    {
       public override string Message { get;}
       public EmployeeException(string Message)
       {
            this.Message = Message;
       }
    }
}
