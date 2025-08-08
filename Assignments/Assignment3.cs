using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumant_Assignments
{
   
    internal class Assignment3
    {
        static void Main(string[] args)
        {
            //Write a Math Calc Program that allows Users to enter the values and operation and the Program should display the result based on the operator the user has typed. It should be in a loop until the user specifies to close it.
            do
            {
                int num1 = ConsoleUtil.getInputInt("Enter the first number");
                int num2 = ConsoleUtil.getInputInt("Enter the second number");
                Console.WriteLine("===============Menu for operation===============");
                Console.WriteLine("1-Additon  2-Subraction  3-Multiplication  4-Division");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        add(num1, num2);
                        break;

                    case 2:
                        sub(num1, num2);
                        break;

                    case 3:
                        mul(num1, num2);
                        break;

                    case 4:
                        div(num1, num2);
                        break;

                    default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }

            } while (true);
        }

        private static void add(int num1, int num2)
        {
            Console.WriteLine($"The sum of {num1} and {num2} is {num1+num2}");
        }

        private static void sub(int num1, int num2)
        {
            Console.WriteLine($"The diff of {num1} and {num2} is {num1 - num2}");
        }

        private static void mul(int num1, int num2)
        {
            Console.WriteLine($"The product of {num1} and {num2} is {num1 * num2}");
        }

        private static void div(int num1, int num2)
        {
            if (num2 != 0)
            {
                Console.WriteLine($"The division of {num1} and {num2} is {num1 / num2}");
            } else
            {
                Console.WriteLine("Cannot divide by zero!!!!!!");
            }
        }
    }      
    }




    static class ConsoleUtil
    {
        public static string getInputString(string msg)
        {
            Console.WriteLine(msg);
            return Console.ReadLine();
        }

        public static int getInputInt(string msg)
        {
            return int.Parse(getInputString(msg));
        }
    }

