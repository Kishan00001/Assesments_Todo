using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Tasks.Assessment1
{
    class ExpenseDatabase : IExpenseDatabase
    {
        private static readonly string MenuFileName = ConfigurationManager.AppSettings["MenuFile"];

        private static readonly string ExpFileName = ConfigurationManager.AppSettings["ExpenseFile"];
        
        static string  content = File.ReadAllText(MenuFileName);

        static List<Expense> Expenselist = new List<Expense>();

        public Expense this[int index] => throw new NotImplementedException();

        public int Count => throw new NotImplementedException();


        //FileStream fs = new FileStream(ExpFileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        
        public static void ExpenseMenuDriven()
        {
            bool condition = true;
            do
            {
                Console.WriteLine(content);
                string opt = Console.ReadLine().ToUpper();
                switch (opt)
                {
                    case "N": Expense exp = new ExpenseDatabase().AddExpense();
                            new ExpenseDatabase().AddingExpense(exp);
                            break;

                    case "U": int upid = utilities.GetInteger("Enter the id of the Expense to get updated");
                            new ExpenseDatabase().UpdatingExpense(upid);
                            break;

                    case "D": int delid = utilities.GetInteger("Enter the id of the expense to be deleted");
                              new ExpenseDatabase().DeletingExpense(delid);
                              break;

                    case "F": int fid = utilities.GetInteger("Enter the id to find an expense");
                              new ExpenseDatabase().ShowExpense(fid);
                              break;

                    case "A": new ExpenseDatabase().ShowAllExpenses();
                              break;

                    case "S": new ExpenseDatabase().ShowStats();
                             break;

                    default: condition = false;
                              break;
                }
            } while (condition);
        }

        public void ShowStats()
        {
            Console.WriteLine("Available Categories: Education\t Shopping\t Food\t Healthcare\t Maintenance");
            string excat = utilities.GetString("Enter the category to show expenses");
            Console.WriteLine("Category '"+excat+"' Statistics:");
            int sum = 0;
            var records = readAllRecords(ExpFileName);
            foreach (var exp in records)
                if (exp.ExpCategory == excat)
                {
                    ShowExpense(exp.ExpId);
                    sum += exp.ExpAmount;
                }
            Console.WriteLine("Total Expenses spent on Category '"+excat+"' are: "+sum+" Rupees");
        }

        public void ShowAllExpenses()
        {
            var records = readAllRecords(ExpFileName);
            foreach (var exp in records)
                ShowExpense(exp.ExpId);
        }
        public Expense findExp(int id)
        {
            var records = readAllRecords(ExpFileName);
            foreach (var exp in records)
                if (exp.ExpId == id)
                    return exp;
            return null;
        }
        private static List<Expense> readAllRecords(string Expfilename)
        {
            List<Expense> ExpList = new List<Expense>();
            string[] lines = File.ReadAllLines(Expfilename);
            foreach (string line in lines)
            {
                string[] words = line.Split(',');
                var exp = new Expense (int.Parse(words[0]),words[1],words[2],int.Parse(words[3]),words[4]);
                ExpList.Add(exp);
            }
            return ExpList;
        }
        private static void bulkInsertRecord(List<Expense> records)
        {
            foreach (var exp in records)
                writeExpRecordToFile(exp);
            Console.WriteLine("Expense List Updated");
        }
        private static void writeExpRecordToFile(Expense exp)
        {
            var line = $"{exp.ExpId},{exp.ExpDetails},{exp.ExpDate},{exp.ExpAmount},{exp.ExpCategory}\n";
            File.AppendAllText(ExpFileName, line);
        }
        private Expense AddExpense()
        {
            Console.WriteLine("Enter the Expense Information to be added");
            int exId = utilities.GetInteger("Enter the Expense Id to be added");
            string exDetails = utilities.GetString("Enter the Expense Name:");
            string exDate = utilities.GetString("Enter Date of Expense");
            int exAmount = utilities.GetInteger("Enter total amount of Expense");
            string exCategory = utilities.GetString("Enter Category of the Expense");
            Expense exp = new Expense(exId, exDetails, exDate, exAmount, exCategory);
            return exp;
        }
        public void AddingExpense(Expense exp)
        {
            Expenselist.Add(exp);
            var line = $"{exp.ExpId},{exp.ExpDetails},{exp.ExpDate},{exp.ExpAmount},{exp.ExpCategory}\n";
            File.AppendAllText(ExpFileName, line);
            Console.WriteLine("New Expense added successfully");
        }
        public void UpdatingExpense(int id)
        {
            Expenselist = readAllRecords(ExpFileName);
            var exp = Expenselist.Find((temp) => temp.ExpId == id);
            if (exp != null)
            {
                int choice = utilities.GetInteger("Enter which Property to update: \n1 for ExpenseId\n2 for ExpenseDetails\n3 for ExpenseDate\n4 for ExpenseAmount\n5 for ExpenseCategoryn ");
                switch (choice)
                {
                    case 1:
                        int uid = utilities.GetInteger("Enter Expense Id to update");
                        Expenselist[Expenselist.IndexOf(exp)].ExpId = uid;
                        Console.WriteLine("Expense ID updated successfully");
                        break;
                    case 2:
                        string udet = utilities.GetString("Enter Expense Details to update");
                        Expenselist[Expenselist.IndexOf(exp)].ExpDetails = udet;
                        Console.WriteLine("Expense Details updated successfully");
                        break;
                    case 3:
                        string udate = utilities.GetString("Enter Expense Date to update");
                        Expenselist[Expenselist.IndexOf(exp)].ExpDate = udate;
                        Console.WriteLine("Expense Date updated successfully");
                        break;
                    case 4:
                        int uamt = utilities.GetInteger("Enter Expense Amount to update");
                        Expenselist[Expenselist.IndexOf(exp)].ExpAmount = uamt;
                        Console.WriteLine("Expense Amount updated successfully");
                        break;
                    case 5:
                        string ucat = utilities.GetString("Enter Expense Category to update");
                        Expenselist[Expenselist.IndexOf(exp)].ExpCategory = ucat;
                        Console.WriteLine("Expense Category updated successfully");
                        break;
                    default:
                        Console.WriteLine("Invalid Option Choosen");
                        break;
                }
                File.Delete(ExpFileName);
                bulkInsertRecord(Expenselist);
            }
            else throw new Exception("Invalid Expense ID entered");

        }
        public void DeletingExpense(int id)
        {
            var records = readAllRecords(ExpFileName);
            for (int i = 0; i < records.Count; i++)
            {
                if (records[i].ExpId == id)
                {
                    records.RemoveAt(i);
                    break;
                }
            }
            Console.WriteLine("The Expense Information was deleted");
            File.Delete(ExpFileName);
            bulkInsertRecord(records);
        }
        public void ShowExpense(int id)
        {
            Expense exp = findExp(id);
            Console.WriteLine("The Expense Information Of The Expense with Id " + exp.ExpId + " are: ");
            Console.WriteLine("The Expense for : " + exp.ExpDetails + " is : " + exp.ExpAmount + " rupees spent on date: " + exp.ExpDate);
            Console.WriteLine("The Expense Category is: " + exp.ExpCategory + "\n");
        }
        public IEnumerator<Expense> GetEnumerator()
        {
            throw new NotImplementedException();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
