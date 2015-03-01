﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataApp.Core.Models
{
    public partial class Project:BaseEntity
    {
        public Project()
        {
            this.ExpenseItems = new HashSet<ExpenseItem>();
        }

        public string Name { get; set; }

        public virtual ICollection<ExpenseItem> ExpenseItems { get; set; }
    }
}
