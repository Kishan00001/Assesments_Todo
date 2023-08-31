using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Tasks.Tasks
{
    //Question 3: Create a function to demonstrate the usage of method overriding. Call the function in the Main. U can comment the other function calls in the Main
    class Currency
    {
        public virtual void PaymentCurrency()
        {
            string curr = utilities.GetString("Enter the currency you want to choose: ");
            Console.WriteLine($"The entered currency for use is: {curr}");
        }
    }
    class Rupees : Currency
    {
        public override void PaymentCurrency()
        {
            Console.WriteLine("The entered currency is: Rupees!!");
        }
    }
    class Dollar : Currency
    {
        public override void PaymentCurrency()
        {
            Console.WriteLine("The entered currency is: Dollar!!");
        }
    }
    class Task3
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("FOR RUPEES----------->PRESS R\nFOR DOLLAR----------->PRESS D\nFOR OTHERS----------->PRESS O\n------ - TO EXIT PRESS EXIT--------");
                string choice = utilities.GetString("Enter the currency choice: ");
                switch (choice)
                {
                    case "R": var rup = new Rupees(); 
                              rup.PaymentCurrency();
                              break;
                    case "D": var dol = new Rupees(); 
                              dol.PaymentCurrency(); 
                              break;
                    case "EXIT": return;
                    default: var curr = new Currency(); curr.PaymentCurrency(); break;
                }
            } while (true);
        }
    }
}
