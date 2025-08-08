using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sumant_Assignments
{
    internal class Assignment7
    {
        static void Main(string[] args)
        {
            //Implement the body for the following function:
            //static boolean isPrimeNumber(int num)
            //{
            //    // do stuff here
            //    return false;
            //}
            //The function should check and return true only if the number passed as argument is a prime number.

            do
            {
                Console.WriteLine("Enter the number to check prime");
                int n = int.Parse(Console.ReadLine());
                if (isPrimeNumber(n) == true)
                {
                    Console.WriteLine($"{n} is a PRIME number!!");
                }
                else
                {
                    Console.WriteLine($"{n} is NOT a PRIME number!!");
                }
            }while (true);

        }


        public static bool isPrimeNumber(int n)
        {
            if(n <= 1) return false;
            for(int i=2; i<=Math.Sqrt(n); i++)
            {
                if(n % i == 0) return false;
            }
            return true;
        }
    }
}
