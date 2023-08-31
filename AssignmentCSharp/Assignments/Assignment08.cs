using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignments
{
    /*
     Assignment 8:
    Implement the C# function listed below:
    public static void printCalendar(int month, int year) {
	    /// do stuff here
    }
    The function should accept month and year and print the calendar for the same. If inputs are invalid, appropriate error message/s should be printed.
    Sample output for the inputs (8, 2018): image
    PS: Do not use any builtin C# classes like DateTime Divide the function into small reusable functions, if possible.
     */
    class Assignment08
    {
        static void Main(string[] args)
        {
            string date = utilities.GetString("Enter the date {format: MM/YYYY}");
            string[] comp = date.Split('/');
            string day1 = new DateTime(int.Parse(comp[1]), int.Parse(comp[0]), 1).DayOfWeek.ToString();
            string dayname = day1.Substring(0,2).ToUpper();
            List<List<String>> list = new List<List<String>>();
            List<String> sun = new List<String>(); sun.Add("SU");
            List<String> mon = new List<String>(); mon.Add("MO");
            List<String> tue = new List<String>(); tue.Add("TU");
            List<String> wed = new List<String>(); wed.Add("WE");
            List<String> thu = new List<String>(); thu.Add("TH");
            List<String> fri = new List<String>(); fri.Add("FR");
            List<String> sat = new List<String>(); sat.Add("SA");
            list.Add(sun);
            list.Add(mon);
            list.Add(tue);
            list.Add(wed);
            list.Add(thu);
            list.Add(fri);
            list.Add(sat);
            for (int i=0 ,day=1;i<6;i++ )
            {
                if (dayname == list[i][0])
                    day++;

            }
        }
    }
}
