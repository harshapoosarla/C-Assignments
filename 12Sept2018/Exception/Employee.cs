using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Sept2018.ExceptionDemo
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }
        public float Bonus { get; set; }
        public Employee(int id, string name, float salary, float bonus)
        {
            Id = id;
            Name = name;
            Salary = salary;
            if (salary < 0 || salary ==0)
            {
                throw new EmployeeException("Salary cannot be less than or equal to 0");
            }
            else
            {
                Salary = salary;
            }
            if (bonus > (salary / 10))
            {
                throw new EmployeeException("Bonus cannot be greater than 10% of employee salary");
            }
            else
            {
                Bonus = bonus;
            }
        }
        public abstract void GetEmployeeLocation();
    }
}