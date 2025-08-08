using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sumant_Assignments
{
    internal class Assignment6
    {
        static void Main(string[] args)
        { //Implement the body for the following function:
          //static boolean isValidDate(int year, int month,int day)
          //{
          // do stuff here
          //return false;
          //}



            do
            {
                Console.WriteLine("Enter year:");
                int yr = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter month:");
                int month = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter day:");
                int day = int.Parse(Console.ReadLine());
                if(isValidDate(yr, month, day))
                {
                    Console.WriteLine("VALID DATE");
                }else
                {
                    Console.WriteLine("INVALID DATE");
                }
            }while (true);

            





        }

        public static bool isValidDate(int year, int month, int day)
        { 
           
           if(month < 1  || month > 12) return false;
            
           if(day < 1 || day > DateTime.DaysInMonth(year, month)) return false;

            return true;
        }
    }
}
