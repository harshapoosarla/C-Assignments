//Write a program using a switch statement that takes one character value from the user and checks whether the 
//entered value is an arithmetic operator, logical operator, conditional operator, relational operator or something else.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcase

{
    class SwitchOperators
    {
        string c;
        void CheckOperator()
        {
            Console.WriteLine("Enter any any Character to check it is operator or not! :");
            c = Console.ReadLine();
            switch (c)
            {
                //arithmetic operators
                case "+":
                case "-":
                case "*":
                case "/":
                case "%":
                    Console.WriteLine(c + " is Arithmetic operator");
                    break;

                //logical operators 
                case "!":
                case "&&":
                case "||":
                    Console.WriteLine(c + " is Logical operator");
                    break;

                //Conditional operators
                case ">=":
                case "<=":
                case "==":
                    Console.WriteLine(c + " is relational operator");
                    break;

                //Relational operators
                case ">":
                case "<":
                    Console.WriteLine(c + " is Realtional operator");
                    break;

                default:
                    Console.WriteLine("Entered character is Not operator ");
                    break;

            }
        }

        static void Main(string[] args)
        {
            SwitchOperators obj = new SwitchOperators();
            obj.CheckOperator();
            int ch;
            Console.WriteLine("Want to Continue \n1.Yes \n2.No");
            ch = Convert.ToInt16(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Main(args);
                    break;
                default:
                    return;

            }
            Console.ReadKey();
        }
    }
}
