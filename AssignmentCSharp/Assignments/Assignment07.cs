using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    /*Question 7:
     Implement the body for the following function:
        static boolean isPrimeNumber(int num) {
	        // do stuff here
	        return false;
        }
        The function should check and return true only if the number passed as argument is a prime number.
        Write a C# program to call the above function multiple times with different values.
     */
    class Assignment07
    { 
        static void Main(string[] args)
        {
            while (true)
            {
            int num = utilities.GetInteger("Enter the number to check its prime or not");
            if(num<0)
                Console.WriteLine($"Negative numbers are invalid");
            else if(num<2)
                Console.WriteLine($"The number {num} is neither prime nor composite");
            else if (isPrime(num))
                Console.WriteLine($"The number {num} is prime");
            else
                Console.WriteLine($"The number {num} is not prime");
            }
        }

        private static bool isPrime(int num)
        {
            if (num < 4)
                return true;
            for (int i = 2; i * i <= num; i++)
                if (num % i == 0)
                    return false;
            return true;
        }
    }
}
