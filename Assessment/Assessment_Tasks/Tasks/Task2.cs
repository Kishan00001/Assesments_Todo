using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Tasks.Tasks
{
    //Question 2: Create a new file in the name of your name and create a function a function to demonstrate the example of a class usage and call its functions in it. Call this function in the Main program.
    class Kishan
    {
        public static void Input()
        {
            string name = utilities.GetString("Enter your name: ");
            string password = utilities.GetString("Enter your password: ");
            funcDisplay(name, password);
        }
        public static void funcDisplay(string name, string password)
        {
            Console.WriteLine($"Your Name is:- {name} and Password is:- {password}");
        }
    }

    class Task2
    {
        static void Main(string[] args)
        {
            Kishan.Input();
        }
    }
}

