using System;
using System.Collections.Generic;
using System.Text;
using BankingApp.Models;
using BankingApp.Data;
using BankingApp.Utilities;

namespace BankingApp.core
{
    class AccountRepository
    {
        public readonly List<AccountBalance> _accountBalances;

        public readonly List<IAccount> _accountLog;

        public AccountRepository()
        {
            _accountBalances = Database.Balances;
            _accountLog = Database.AccountsLog;

        }
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

        public void UpdateBalancePositive(CurrentAccount account, double amount)
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

        public void UpdateBalanceNegative(CurrentAccount account, double amount)
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

        public void AssignAccountNumber(IAccount account)
        {
            Random random = new Random();
            bool validAccountNumber = default;
            long accountNumber;
            do
            {
                accountNumber = random.Next(0060000000, 0069999999);
                if (Utilities.Utilities.ValidateAccountNumber(accountNumber) == false)
                {
                    validAccountNumber = true;
                }
            } while (validAccountNumber == false);
            account.AccountNumber = accountNumber;
        }
    }
}
