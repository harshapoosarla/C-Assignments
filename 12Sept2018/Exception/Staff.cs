using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Sept2018.ExceptionDemo
{
    class Staff : Employee, ICalculateAll
    {
        public int BenchNumber { get; set; }
        public Staff(int id, string name, float salary ,float bonus) : base(id, name, salary, bonus)
        {
        }
        public float GetExpense()
        {
            return Salary * 2;
        }
        public float GetSalary()
        {
            return Salary;
        }
        public override void GetEmployeeLocation()
        {
            Console.WriteLine("Work Location");
        }
    }
}
