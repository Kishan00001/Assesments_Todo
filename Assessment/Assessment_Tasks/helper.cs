using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Tasks
{
    class helper
    {
        static void Main(string[] args)
        {
            //Console.WriteLine((int)'z');
            //string loadedString = "04/23/2009";
            //DateTime loadedDate = DateTime.ParseExact(loadedString, "d",null);
            //Console.WriteLine(loadedDate.ToString("dd/MM/yyyy"));
            string loadedString = "04/23/2009";
            string date = DateTime.ParseExact(loadedString, "d",null).ToString("dd/MM/yyyy");
            Console.WriteLine(date);
        }
    }
}
