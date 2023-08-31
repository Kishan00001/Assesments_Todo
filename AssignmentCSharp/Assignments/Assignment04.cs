using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    //Question 4 : Write a program that creates an array and displays the contents of the array. The array should be created dynamically. It means that the size, type should be set by the user of the Program. Take inputs for the values also. Finally it should display the values of the array.
    class Assignment04
    {
        static void Main(string[] args)
        {

            int size = utilities.GetInteger("Enter the size of the array");
            string dataType = utilities.GetString("Enter the datatype(CTS Name) for the array");
            Type type = Type.GetType(dataType);
            if (type == null)
            {
                Console.WriteLine("Invalid datatype can not create array");
                return;
            }
            Array arr = Array.CreateInstance(type, size);
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter the value for the array at index {i} of the data type {type.Name}");
                var value = Convert.ChangeType(Console.ReadLine(), type);
                arr.SetValue(value, i);
            }
            Console.WriteLine("All the values are set \nThe values are: ");
            foreach (var item in arr)
                Console.Write(item + " ");
        }
    }
}