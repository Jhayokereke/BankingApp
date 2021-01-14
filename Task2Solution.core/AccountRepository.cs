using System;
using System.Collections.Generic;
using System.Text;
using Task2Solution.Models;
using Task2Solution.Data;
using Task2Solution.Utilities;

namespace Task2Solution.core
{
    class AccountRepository
    {
        public AccountBalance GetBalance(CurrentAccount account)
        {
            var balance = new AccountBalance();
            foreach (var customerAccount in Database.Balances)
            {
                if (customerAccount.AccountNumber == account.AccountNumber)
                {
                    return balance = new AccountBalance { AccountNumber = account.AccountNumber, CurrentBalance = account.CurrentBalance };
                }
            }
            return balance;
        }

        public void UpdateBalancePositive(CurrentAccount account, float amount)
        {
            var balance = new AccountBalance();
            foreach (var customerAccount in Database.Balances)
            {
                if (customerAccount.AccountNumber == account.AccountNumber)
                {
                    customerAccount.CurrentBalance += amount;
                    break;
                }
            }
        }

        public void UpdateBalanceNegative(CurrentAccount account, float amount)
        {
            var balance = new AccountBalance();
            foreach (var customerAccount in Database.Balances)
            {
                if (customerAccount.AccountNumber == account.AccountNumber)
                {
                    customerAccount.CurrentBalance -= amount;
                    break;
                }

                //throw new Exception("Cannot exceed minimum balance..."); //cut and move away
            }
        }

        public static long AssignAccountNumber(string ID)
        {
            Random random = new Random();
            bool validAccountNumber = default;
            long accountNumber;
            do
            {
                accountNumber = random.Next(0060000000, 0069999999);
                if (Utilities.ValidateAccountNumber(accountNumber) == false)
                {
                    validAccountNumber = true;
                }
            } while (validAccountNumber == false);
            return accountNumber;
        }
    }
}
