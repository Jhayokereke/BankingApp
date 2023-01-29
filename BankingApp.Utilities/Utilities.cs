using System;
using System.Linq;
using BankingApp.Data;

namespace BankingApp.Utilities
{
    public class Utilities
    {
        public static bool AboveMinBal(double balance, double amount, double minValue)
        {
            if (balance - amount < minValue)
            {
                return false;
            }
            else return true;
        }

        public static bool ValidateID(string id)
        {
            //checks database to ensure no two randomly generated IDs are the same
            var matches = Database.CustomerLog.Any(p => String.Equals(p.ID, id, StringComparison.CurrentCulture));
            return matches;
        }

        public static bool ValidateAccountNumber(long accountNumber)
        {
            //checks database to ensure no two randomly generated account numbers are the same
            var matches = Database.AccountsLog.Any(p => long.Equals(p.AccountNumber, accountNumber));
            return matches;
        }
    }
}
