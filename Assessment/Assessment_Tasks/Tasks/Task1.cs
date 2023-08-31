using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Tasks.Tasks
{
    //Questions 1: Create a console app that has a function to create an array, fill the data and display the contents of the array.
    class Task1
    {
        static void Main(string[] args)
        {
            string datattype = utilities.GetString("Enter the datatype: ");
            Type type = Type.GetType(datattype);
            int size = utilities.GetInteger("Enter the size of array: ");
            Array arr = Array.CreateInstance(typeof(string), size);
            Console.WriteLine("Enter the elements of the array");
            for(int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter the {i + 1} value: ");
                var value = Console.ReadLine();
                arr.SetValue(value, i);
            }
            Console.WriteLine("The elements of the array are: ");
            foreach (var item in arr)
                Console.Write(item+" ");
            Console.WriteLine();
        }
    }
}
