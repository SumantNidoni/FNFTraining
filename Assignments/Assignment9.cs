using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sumant_Assignments
{
    internal class Assignment9
    {
        static void Main(string[] args)
        {
            //Write a function called "reverseByWords", that takes a sentence(string) as an input, and returns another string.The return value must be a sentence in which the words in the original sentence appear in reverse order.


            //public static string reverseByWords(string sentence)
            //      {
            // do stuff here
            //           return null;
            //        }


            //For example,

            //String out = reverseByWords("my name is vinod and i live in bangalore");

            // the variable "out" should be equal to "bangalore in live i and vinod is name my".

            //Call the function in main, multiple times by supplying multiple values and verify the same.

            do
            {
                Console.WriteLine("Enter the sentence");
                string sentence = Console.ReadLine();
                string res = reverseByWords(sentence);
                Console.WriteLine(res);

            }while (true);
    }

        public static string reverseByWords(string sentence)
        {
            string[] arr = sentence.Split(' ');
            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            string[] revArr = revereArray(arr);
            return string.Join(" ",arr);
        }


        public static string[] revereArray(string[] arr)
        {
            int i = 0,j = arr.Length-1;
            while( i < j )
            {
                string temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
            return arr;
        }
    }
}
