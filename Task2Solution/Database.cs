using System.Collections.Generic;

namespace Task2Solution
{
    class Database
    {
        public static List<IAccount> AccountsLog { get; set; } = new List<IAccount>();

        public static List<ICustomer> CustomerLog { get; set; } = new List<ICustomer>();

        public static List<AccountBalance> Balances { get; set; } = new List<AccountBalance>();
    }
}
