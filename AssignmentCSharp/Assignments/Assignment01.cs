using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    //Question 1 : Write a program that displays the range of all the floating and integral types of.NET CTS
    enum DataType{ bytes,shorts,ints,longs,floats,doubles,decimals, chars}
    class Assignment01
    {
        static void Main(string[] args)
        {
            //foreach(string str in DataType)
            //{

            //}
            Console.WriteLine($"The range of byte is {byte.MinValue} and {byte.MaxValue}");
            Console.WriteLine($"The range of short is {short.MinValue} and {short.MaxValue}");
            Console.WriteLine($"The range of int is {int.MinValue} and {int.MaxValue}");
            Console.WriteLine($"The range of long is {long.MinValue} and {long.MaxValue}");
            Console.WriteLine($"The range of float is {float.MinValue} and {float.MaxValue}");
            Console.WriteLine($"The range of double is {double.MinValue} and {double.MaxValue}");
            Console.WriteLine($"The range of decimal is {decimal.MinValue} and {decimal.MaxValue}");
            Console.WriteLine($"The range of char is {char.MinValue} and {char.MaxValue}");
            //Console.WriteLine($"The range of double is {bool.MinValue} and {bool.MaxValue}");  Complete 
        }

    }
}
