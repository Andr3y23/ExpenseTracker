using DataApp.Core.Enums;
namespace DataApp.Core.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExpenseItem
    {
        public ExpenseItem()
        {
            this.Projects = new List<Project>();
        }
    
        public int Id { get; set; }
        public System.DateTime PurchaseDate { get; set; }
        public string Notes { get; set; }
        public string ORNumber { get; set; }
        public decimal Amount { get; set; }
        public ExpenseCategory Category { get; set; }
        public int ExpenseId { get; set; }
        public int TransactionAccountId { get; set; }
    
        public virtual Expense Expense { get; set; }
        public virtual List<Project> Projects { get; set; }
        public virtual TransactionAccount TransactionAccount { get; set; }
    }
}
