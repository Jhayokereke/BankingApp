using System;
using System.Collections.Generic;
using System.Text;

namespace Task2Solution.Models
{
    class SavingsAccount : IAccount
    {
        public string AccountType { get; set; }

        public long AccountNumber { get; set; }

        public double MinAmount { get; set; }

        public double CurrentBalance { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
