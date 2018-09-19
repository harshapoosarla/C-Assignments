using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Sept2018.ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Staff Staff1 = new Staff(1, "Harsha", 5000, 500);
                Manager Manager1 = new Manager(2, "Harsha", 10000, 100, 1000);
                Salesman Salesman1 = new Salesman(3, "Harsha", 6000, "Hyderabad", 2000, 600);

                Console.WriteLine("\nStaff Name :" + Staff1.Name);
                Console.WriteLine("Staff Salary :" + Staff1.GetSalary());
                Console.WriteLine("Staff Expenses :" + Staff1.GetExpense());
                Console.WriteLine("Bonus Amount:"+Staff1.Bonus);
                //Manager Details
                Console.WriteLine("\nManager Name :" + Manager1.Name);
                Console.WriteLine("Manager Stock :" + Manager1.Stock);
                Console.WriteLine("Manager Stock :" + Manager1.GetSalary());
                Console.WriteLine("Manager Expenses :" + Manager1.GetExpense());
                Console.WriteLine("Bonus Amount:"+Manager1.Bonus);

                //SalesMan Details
                Console.WriteLine("\nSalesman Name :" + Salesman1.Name);
                Console.WriteLine("Salesman Salary :" + Salesman1.Location);
                Console.WriteLine("Salesman Loacation :" + Salesman1.GetSalary());
                Console.WriteLine("Salesman Expenses :" + Salesman1.GetExpense());
                Console.WriteLine("Bonus Amount:"+Salesman1.Bonus);

            }
            catch (ApplicationException e)
            {
                Console.WriteLine("Exception Occured :" + e.Message);
            }
            catch (Exception e)
            {
            }
            Console.ReadKey();
        }
    }
}
