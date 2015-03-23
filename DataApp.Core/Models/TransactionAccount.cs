//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataApp.Core.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TransactionAccount
    {
        public TransactionAccount()
        {
            this.Vouchers = new List<Voucher>();
            this.Checks = new List<Check>();
            this.ExpenseItems = new List<ExpenseItem>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }

        public virtual List<Voucher> Vouchers { get; set; }
        public virtual List<Check> Checks { get; set; }
        public virtual List<ExpenseItem> ExpenseItems { get; set; }
    }
}
