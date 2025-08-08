using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sumant_Assignments
{
    internal class Assignment2
    {
        static void Main(string[] args)
        {
            //Write a function that takes an array of numbers and it should display the Odd and Even numbers
            Console.WriteLine("Enter size of array");
            int[] nums = new int[int.Parse(Console.ReadLine())];
            takeArrInp(nums);
            printArray(nums);
            oddEveArrayElemsinArr(nums);


        }

        public static void takeArrInp(int[] arr)
        {
            Console.WriteLine("Enter the elements:");
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
        }

        public static void printArray(int[] arr)
        {
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }



        public static void oddEveArrayElemsinArr(int[] arr)
        {
            Console.WriteLine("Even Numbers are:");
            displayEvenElems(arr);
            Console.WriteLine("Odd Numbers are:");
            displayOddElems(arr);

        }


        public static void displayEvenElems(int[] arr)
        {
            foreach(int i in arr)
            {
                if(i % 2 == 0)
                {
                    Console.Write(i+" ");
                }
            }
            Console.WriteLine();
        }

        public static void displayOddElems(int[] arr)
        {
            foreach(int i in arr)
            {
                if(i % 2 != 0)
                {
                    Console.Write(i+" ");
                }
            }
            Console.WriteLine();
        }
    }
}
