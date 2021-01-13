using System;
using System.Collections.Generic;
using System.Text;

namespace Task2Solution
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
    }
}
