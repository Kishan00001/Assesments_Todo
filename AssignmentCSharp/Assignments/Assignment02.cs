using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    //Question02 : Write a function that takes an array of numbers and it should display the Odd and Even numbers
    class Assignment02
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 21, 30, 23, 33, 74, 45, 90, 32, 42, 81 };
            Console.Write("Odd Elements are:");
            foreach (int ele in arr)
                if (ele % 2 != 0)
                    Console.Write(ele + " ");
            Console.WriteLine();
            Console.Write("Even Elements are:");
            foreach (int ele in arr)
                if (ele % 2 == 0)
                    Console.Write(ele + " ");
            Console.WriteLine();
        }
    }
}
