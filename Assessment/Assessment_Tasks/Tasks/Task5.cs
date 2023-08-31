using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Tasks.Tasks
{
    //Question 5: Create an example to demonstrate the usage of interface programming.
    interface IExample
    {
        void getData(string name, int rollNO);
        void setData();
    }
    class Example : IExample
    {
        public void getData(string name, int rollNo)
        {
            Console.WriteLine($"Roll No. of {name} is {rollNo}");
        }
        public void setData()
        {
            string name = utilities.GetString("Enter the name: ");
            int rollNo = utilities.GetInteger("Enter the roll no: ");
            getData(name, rollNo);
        }
    }
    class Task5
    {
        static void Main(string[] args)
        {
            Example ex = new Example();
            ex.setData();
        }
    }
}
