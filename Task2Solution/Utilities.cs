using System;
using System.Linq;
using Task2Solution;

namespace Task2Solution.Utilities
{
    class Utilities
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
            //checks database to ensure no two randomly generated IDs are a complete match
            var matches = Database.CustomerLog.Any(p => String.Equals(p.ID, id, StringComparison.CurrentCulture));
            return matches;
        }

        public static bool ValidateAccountNumber(long accountNumber)
        {
            //checks database to ensure no two randomly generated IDs are a complete match
            var matches = Database.AccountsLog.Any(p => long.Equals(p.AccountNumber, accountNumber));
            return matches;
        }

        public static long AssignAccountNumber()
        {
            Random random = new Random();
            bool validAccountNumber = default;
            long accountNumber;
            do
            {
                accountNumber = random.Next(0060000000, 0069999999);
                if (ValidateAccountNumber(accountNumber) == false)
                {
                    validAccountNumber = true;
                }
            } while (validAccountNumber == false);
            return accountNumber;
        }
    }
}
