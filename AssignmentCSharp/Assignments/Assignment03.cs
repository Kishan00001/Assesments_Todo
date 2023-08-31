using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    // Question 3: Write a Math Calc Program that allows Users to enter the values and operation and the Program should display the result based on the operator the user has typed. It should be in a loop until the user specifies to close it.
    class Assignment03
    {
            static bool getResult(double v1, double v2, string choice)
            {
                switch (choice)
                {
                    case "+":
                        Console.WriteLine($"The added value is {v1 + v2}");
                        return true;
                    case "-":
                        Console.WriteLine($"The added value is {v1 - v2}");
                        return true;
                    case "*":
                        Console.WriteLine($"The added value is {v1 * v2}");
                        return true;
                    case "/":
                        Console.WriteLine($"The added value is {v1 / v2}");
                        return true;
                    default:
                        Console.WriteLine("Its an invalid Choice");
                        return false;
                }
            }
            static void Main(String[] args)
            {
                bool processing = true;
                do
                {
                    double v1 = utilities.GetDouble("Enter the first value");
                    double v2 = utilities.GetDouble("Enter the second value");
                    string choice = utilities.GetString("Enter the choice of operation: +, -, * or /");
                    processing = getResult(v1, v2, choice);
                } while (processing);
            }
        }
    }
