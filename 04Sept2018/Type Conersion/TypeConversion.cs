//Write a program using a switch statement that takes one value from the user and asks about the type 
//of conversion and then performs a conversion depending on the type of conversion.If user enters: 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class TypeConversionDemo
    {
        void conversiontype()
        {
            Console.WriteLine("enter the value to be converted:");
            string input = Console.ReadLine();
            Console.WriteLine("convert to \n 1.Integer \n 2.Float \n 3.Double");
            switch (Console.ReadLine())
            {
                case "1":
                    {
                        float n = 0;
                        bool possible = float.TryParse(input, out n);
                        if (possible)
                        {
                            Console.WriteLine("Explicitly converting the string to integer:" + (int)n);
                        }
                        else
                        {
                            Console.WriteLine("Explicitly converting to integer is not possible");
                        }
                    }
                    break;
                case "2":
                    {
                        float n = 0;
                        bool possible = float.TryParse(input, out n);
                        if (possible)
                        {
                            Console.WriteLine("Explicitly converting the string to float: " + n);
                        }
                        else
                        {
                            Console.WriteLine("Explicitly converting to float is not possible:");
                        }
                    }
                    break;
                case "3":
                    {
                        double n = 0;
                        bool possible = double.TryParse(input, out n);
                        if (possible)
                        {
                            Console.WriteLine("Explicitly converting string to double :" + n);
                        }
                        else
                        {
                            Console.WriteLine("Explicitly converting not possible to double");
                        }
                    }

                    break;
                case "4":
                    {
                        double n = 0;
                        bool possible = double.TryParse(input, out n);
                        if (possible)
                        {
                            Console.WriteLine("Explicitly converting string to long :" + (long)n);
                        }
                        else
                        {
                            Console.WriteLine("Explicitly converting not possible to long");
                        }
                    }

                    break;

            }
        }
        static void Main(string[] args)
        {
            TypeConversionDemo tcd = new TypeConversionDemo();
            tcd.conversiontype();
            Console.ReadLine();
        }
        
    }
    
}
