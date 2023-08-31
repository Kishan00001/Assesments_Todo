using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    /* Question 6:
    Implement the body for the following function:
    static boolean isValidDate(int year, int month, int day) { 
	    // do stuff here
	    return false;
    }
    The function should check if the parameter values constitute a valid calendar date or not. Accordingly return true or false.
    For example,
    year=2018, month=13, day=1 is an invalid date as the possible values for month is 1 to 12.
    year=2018, month=2, day=29 is an invalid date as the maximum days in February is 28 in the year 2018
    year=2016, month=2, day=29 is a valid date.
    Write a C# program to call the above function multiple times with different values.
     */
    class Assignment06
    {
        static void Main(string[] args)
        {
            string date = utilities.GetString("Enter the date {format:DD/MM/YYYY}");
            string[] comp = date.Split('/');
            bool val = isValidDate(int.Parse(comp[2]), int.Parse(comp[1]), int.Parse(comp[0]));
            if (val)
                Console.WriteLine("It is a valid date");
            else
                Console.WriteLine("Invalid date format entered");
        }

        private static bool isValidDate(int year, int month, int day)
        {
            bool checkLeap = checkLeapYear(year);
            int[] monthdays = new int[]{31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            if (year < 1 || year > 9999 || month < 1 || month > 12 || day < 1 || day > 31)
                return false;
            else if (checkLeap && month == 2 && day < 30)
                return true;
            else if ( day > monthdays[month - 1])
                return false;
            return true;
        }

        private static bool checkLeapYear(int year)
        {
            if ((year % 400 == 0) ||  (year % 100 != 0) && (year % 4 == 0))
                return true;
            else
                return false;
        }
    }
}
