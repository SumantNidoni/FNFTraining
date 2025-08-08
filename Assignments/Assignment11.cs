using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sumant_Assignments
{
    internal class Assignment11
    {
        static void Main(string[] args)
        {
            //Write a Function that returns a interest amount for a Principal Amount for a term with a specific rate of interest Let the inputs for the function be in the form of parameters.

            
            Console.WriteLine(simpleInterest(5000, 6, 3));
            Console.WriteLine(compundInterest(5000, 6, 3));
        }


        public static float simpleInterest(int p, int t, float r)
        {
            //total amt = SI + Princicple;
            return (float)(p * t * r)/100;
        }

        public static double compundInterest(int p, int t, float r)
        {
            double CI = p * Math.Pow((1 + r / 100), t) - p;
            return CI;
        }
    }
}
