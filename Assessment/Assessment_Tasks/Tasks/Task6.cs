using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Tasks.Tasks
{
    //Question 6: Create a program to show display the contents of the Array passed as argument in reverse order. You should create a function that calls the function that takes an array as an argument and returns the array in reverse order. Call the function and reverse the order.
    class Task6
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 7, 3, 9, 4, 6 };
            reverseArray(ref arr);
            Console.WriteLine("The reversed array is");
            foreach (int ele in arr)
                Console.Write(ele + " ");
        }

        private static void reverseArray(ref int[] arr)
        {
            int temp,beg = 0,end=arr.Length-1;
            while (beg < end)
            {
                temp = arr[beg];
                arr[beg] = arr[end];
                arr[end] = temp;
                beg++;
                end--;
            }
        }
    }
}
