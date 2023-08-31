using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Tasks.Tasks
{
    //Question 4: Create an enum for WeekDays, Create a function that internally creates the enum object based on the input given by the User and display the selected Enum Value. Call the function in the Main Program that is already created.
    class Task4
    {
        enum WeekDays
        {
            Sunday,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday
        };
        static void Main(string[] args)
        {
            //var arrayofvalues = Enum.GetValues(typeof(WeekDays));
            //foreach (var value in arrayofvalues)
            //    Console.Write(value+" ");
            //Console.WriteLine();
            //Console.WriteLine("Enter the day name you want:");
            //string input = Console.ReadLine();
            //var convertedValue = Enum.Parse(typeof(WeekDays), input);
            //WeekDays day = (WeekDays)convertedValue;
            //Console.WriteLine("The selected Day is is " + day);
            
            Console.WriteLine("Enter the Day as 0..6");
            WeekDays day = (WeekDays)int.Parse(Console.ReadLine());
            Console.WriteLine("The selected day is " + day);

        }
    }
}
