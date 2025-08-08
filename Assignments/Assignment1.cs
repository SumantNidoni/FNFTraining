using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumant_Assignments
{
    //Write a program that displays the range of all the floating and integral types of.NET CTS
    internal class Assignment1
    {
        static void Main(string[] args)
        {
            IntegralDataTypesRanges();
            Console.WriteLine();
            FloatingDataTypesRanges();

        }

        private static void FloatingDataTypesRanges()
        {
            Console.WriteLine();
            Console.WriteLine("Floating data types and their ranges are as follows:");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine($"float => Min range: {float.MinValue}     Max range: {float.MaxValue}");
            Console.WriteLine($"double => Min range: {double.MinValue}   Max range: {double.MaxValue}");
            Console.WriteLine($"decimal => Min range: {decimal.MinValue} Max range: {decimal.MaxValue}");
        }

        private static void IntegralDataTypesRanges()
        {
            Console.WriteLine("Integral data types and their ranges are as follows:");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine($"int => Min range: {int.MinValue}         Max range: {int.MaxValue}");
            Console.WriteLine($"uint => Min range: {uint.MinValue}       Max range: {uint.MaxValue}");
            Console.WriteLine($"short => Min range: {short.MinValue}     Max range: {short.MaxValue}");
            Console.WriteLine($"ushort => Min range: {ushort.MinValue}   Max range: {ushort.MaxValue}");
            Console.WriteLine($"byte => Min range: {byte.MinValue}       Max range: {byte.MaxValue}");
            Console.WriteLine($"sbyte => Min range: {sbyte.MinValue}     Max range: {sbyte.MaxValue}");
            Console.WriteLine($"long => Min range: {long.MinValue}       Max range: {long.MaxValue}");
            Console.WriteLine($"ulong => Min range: {ulong.MinValue}     Max range: {ulong.MaxValue}");
        }
    }
}
