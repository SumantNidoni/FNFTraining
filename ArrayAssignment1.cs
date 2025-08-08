using Assignments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumant_Assignments
{
    internal class ArrayAssignment1
    {
        static void Main(string[] args)
        {
            //Write a program that takes an array as argument, it should display the transpose matrix format of the array
            int[,] arr = new int[2, 3];
            Console.WriteLine(arr.GetLength(0));
            Console.WriteLine(arr.GetLength(1));
            for(int i=0; i<arr.GetLength(0); i++)
            {
                for(int j=0; j<arr.GetLength(1); j++)
                {
                    arr[i,j] = int.Parse(Console.ReadLine());

                }
            }
            Console.WriteLine("Array before Transpose of a Matrix");
            PrintArray(arr);
            Console.WriteLine("Array After Transpose of a Matrix");
            int[,] transArray = TransposeArray(arr);
            PrintArray(transArray);


        }


        public static void PrintArray(int[,] arr)
        {
            for(int i =0;i<arr.GetLength(0); i++)
            {
                for(int j=0; j<arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]);
                }
                Console.WriteLine();
            }
        }
        public static int[,] TransposeArray(int[,] arr)
        {
            

            int[,] trans = new int[arr.GetLength(1), arr.GetLength(0)];
            for(int i=0; i<trans.GetLength(0); i++)
            {
                for(int j=0; j < trans.GetLength(1); j++)
                {
                    trans[i, j] = arr[i, j];
                }
            }
            return trans;
        }
    }
}
