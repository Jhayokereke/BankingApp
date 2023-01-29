using System.Collections.Generic;
using BankingApp.Models;

namespace BankingApp.Data
{
    public class Database
    {
        public static List<IAccount> AccountsLog { get; set; } = new List<IAccount>();

        public static List<ICustomer> CustomerLog { get; set; } = new List<ICustomer>();

        public static List<AccountBalance> Balances { get; set; } = new List<AccountBalance>();
    }
}
