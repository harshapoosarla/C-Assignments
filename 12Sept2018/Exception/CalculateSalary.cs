using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Sept2018.ExceptionDemo
{
    public interface ICalculateSalary
    {
        float GetSalary();
    }
    public interface ICalculateExpense
    {
        float GetExpense();
    }
    public interface ICalculateAll:ICalculateExpense,ICalculateSalary
    {
    }
}
