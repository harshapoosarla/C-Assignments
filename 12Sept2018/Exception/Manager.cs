using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Sept2018.ExceptionDemo
{
    class Manager : Employee, ICalculateAll
    {
        public int Stock { get; set; }
        public float GetSalary()
        {
            return Salary + ((Stock * 1000f) / 100f);
        }
        public float GetExpense()
        {
            return Salary / 2;
        }
        public Manager(int id, string name, float salary, int stock, float bonus) : base(id, name, salary, bonus)
        {
            Stock = stock;
        }
        public override void GetEmployeeLocation()
        {
            Console.WriteLine("Work Location");
        }
    }
}
