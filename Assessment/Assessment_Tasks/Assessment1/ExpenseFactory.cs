using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Tasks.Assessment1
{
    interface IExpenseDatabase : IEnumerable<Expense>
    {
        void AddingExpense(Expense expense);
        void UpdatingExpense(int id);
        void DeletingExpense(int id);
        void ShowExpense(int id);

        void ShowAllExpenses();
        void ShowStats();
        int Count { get; }
        Expense this[int index] { get; }
    }
    class ExpenseFactory
    {
        public static IExpenseDatabase GetComponent(string type)
        {
            switch (type.ToLower())
            {
                case "expense": return new ExpenseDatabase();
                default: return new ExpenseDatabase();
            }
        }
    }
}
