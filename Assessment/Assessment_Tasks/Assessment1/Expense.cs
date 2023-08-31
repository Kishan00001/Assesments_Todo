using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Tasks.Assessment1
{
    class Expense
    {
        public int ExpId { get; set; }
        public string ExpDetails { get; set; }
        public string ExpDate { get; set; }
        public int ExpAmount { get; set; }
        public string ExpCategory { get; set; }
        public Expense(){}
        public Expense (int ExpId, string ExpDetails, string ExpDate, int ExpAmount, string ExpCategory)
        {
            this.ExpId = ExpId;
            this.ExpDetails = ExpDetails;
            this.ExpDate = ExpDate;
            this.ExpAmount = ExpAmount;
            this.ExpCategory = ExpCategory;
        }
    }
}
