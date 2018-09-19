//Write a program using conditional operators to determine whether a year entered through the keyboard is a leap year or not.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Year=0;
            bool check = false;
            while (check != true)
            {
                Console.WriteLine("Enter the year to be checked:");
                check = int.TryParse(Console.ReadLine(), out Year);
            }
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            Console.WriteLine("it is a Leap Year.", Year);
            else Console.WriteLine("it is not leap year");
            Console.ReadKey(); 
        }
    }
}
