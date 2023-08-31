using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Tasks.Assessment1
{
    /*Develop a console application in C# with the features of Interface Programming, Factory Pattern and Exception Handling with Custom Exception along with a menu-driven program with a menu created in a text file. The application should be implemented using any of the features assigned to you. However the functionality will remain the having all CRUD operations on it.*/
    class ExpenseTracker
    {
        //In memory collection of Expense of an user... improvise to CSV file.
        private static readonly string ExpFileName = ConfigurationManager.AppSettings["ExpenseFile"];
        static void Main(string[] args)
        {
            File.Delete(ExpFileName);
            var comp = ExpenseFactory.GetComponent("expense");
            comp.AddingExpense(new Expense(1, "Clothes", "08/31/2023", 3000, "Shopping"));
            comp.AddingExpense(new Expense(2, "Tuition", "08/28/2023", 5000, "Education"));
            comp.AddingExpense(new Expense(3, "Breakfast", "08/13/2023", 50, "Food"));
            comp.AddingExpense(new Expense(4, "Recharge", "08/12/2023", 500, "Maintenance"));
            comp.AddingExpense(new Expense(5, "Medicine", "08/23/2023", 1000, "Healthcare"));
            comp.AddingExpense(new Expense(6, "Dinner", "08/21/2023", 200, "Food"));
            comp.AddingExpense(new Expense(7, "Groceries", "08/11/2023", 800, "Shopping"));
            comp.AddingExpense(new Expense(8, "Lunch", "08/19/2023", 150, "Food"));
            comp.AddingExpense(new Expense(9, "MedCheckUp", "08/10/2023", 300, "Healthcare"));
            comp.AddingExpense(new Expense(10, "College", "08/30/2023", 10000, "Education"));

            ExpenseDatabase.ExpenseMenuDriven();
        }
    }
}
