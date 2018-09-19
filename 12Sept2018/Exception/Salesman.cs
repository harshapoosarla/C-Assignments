using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Sept2018.ExceptionDemo
{
    class Salesman : Employee, ICalculateAll
    {
        public string Location { get; set; }
        public float Commission { get; set; }

        public float GetSalary()
        {
            return Salary + Commission;
        }
        public float GetExpense()
        {
            return Salary * 2;
        }
        public Salesman(int id, string name, float salary, string location, float commission, float bonus) : base(id, name, salary, bonus)
        {
            Location = location;
            Commission = commission;
        }
        public override void GetEmployeeLocation()
        {
            Console.WriteLine("Work Location");
        }
    }
}
