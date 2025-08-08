using Assignments;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sumant_Assignments
{
    internal class Assignment4
    {

        //Write a program that creates an array and displays the contents of the array.The array should be created dynamically.It means that the size, type should be set by the user of the Program. Take inputs for the values also.Finally it should display the values of the array.
        static void Main(string[] args)
        {

            string arrtype = ConsoleUtil.getInputString("Enter the type of Array : int or float or string or double or char");

            int size = int.Parse(ConsoleUtil.getInputString("Enter the size of the array"));

            //object obj = creqatea();

            //if (obj is int[] intArr)
            //{
            //    intArr
            //}

         
            switch(arrtype)
            {
                case "int":
                    int[] intArray = takeIntInput(size);
                    DisplayArray(intArray);
                    //return intArray;
                    break;

                case "float":
                    float[] floatArray = takeFloatInput(size);
                    DisplayArray(floatArray);
                    break;

                case "double":
                    double[] doubleArray = takeDoubleInput(size);
                    DisplayArray(doubleArray);
                    break;

                case "string":
                    string[] stringArray = takeStringInput(size);
                    DisplayArray(stringArray);
                    break;

                case "char":
                    char[] charArray = takeCharInput(size);
                    DisplayArray(charArray);
                    break;

                default:
                    Console.WriteLine("Invalid type!!..Please enter a valid datatype for array...");
                    break;

            }
                
            

            
        }

        private static char[] takeCharInput(int size)
        {
            char[] arr = new char[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = char.Parse(Console.ReadLine());
            }
            return arr;

        }

        private static string[] takeStringInput(int size)
        {
            string[] arr = new string[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Console.ReadLine();
            }
            return arr;
        }

        private static double[] takeDoubleInput(int size)
        {
            double[] arr = new double[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
            }
            return arr;
        }

        //ERROR IN THIS FUNCTION
        private static float[] takeFloatInput(int size)
        {
            float[] arr = new float[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = float.Parse(Console.ReadLine());
            }
            return arr;
        }

        private static int[] takeIntInput(int size)
        {
            int[] arr = new int[size];
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }

        private static void DisplayArray<T>(T[] arr)
        {
            Console.WriteLine("Array elements are:");
            foreach(var i in arr)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
    }
}
