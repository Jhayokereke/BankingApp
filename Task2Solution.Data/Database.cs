using System.Collections.Generic;
using Task2Solution.Models;

namespace Task2Solution.Data
{
    public class Database
    {
        public static List<IAccount> AccountsLog { get; set; } = new List<IAccount>();

        public static List<ICustomer> CustomerLog { get; set; } = new List<ICustomer>();

        public static List<AccountBalance> Balances { get; set; } = new List<AccountBalance>();
    }
}
