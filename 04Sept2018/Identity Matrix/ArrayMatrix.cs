//Write a program that prints an identity matrix using a for loop, in other words takes a value n from the user and shows the identity table of size n * n

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class ArrayMatrix
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a two dimensional matrix");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<n;i++)
            {
                Console.WriteLine("\n");
                for (int j=0;j<n;j++)
                {
                    Console.Write("\t");
                    if (i == j)
                    {
                        Console.Write("1");
                    }
                    else Console.Write("0");
                    
                }


            }



            Console.ReadLine();
        }
    }
}
