using System;
using System.Collections.Generic;
using System.Text;
using BankingApp.Models;
using BankingApp.Data;

namespace BankingApp.core
{
    class CustomerRepository
    {
        private readonly AccountRepository _accountRepository;

        //constructor
        public CustomerRepository()
        {
            _accountRepository = new AccountRepository();
        }

        //get customer by email
        public ICustomer GetCustomerByEmail(string email)
        {
            ICustomer customertoreturn;

            foreach (var customer in Database.CustomerLog)
            {
                if (customer.Email == email)
                {
                    customertoreturn = new Customer
                    {
                        Name = customer.Name,
                        Email = customer.Email,
                        ID = customer.ID,
                        PasswordHash = customer.PasswordHash,
                        PasswordSalt = customer.PasswordSalt,
                        CustomerAccounts = _accountRepository.
                    }
                }
            }
            //code goes here

        }

        //get customer by account
        public ICustomer GetCustomerByAccount(string accountnumber)
        {
            //code goes here
        }

        //update customer details
        public ICustomer UpdateCustomer(string email)
        {
            //code goes here
        }

        public string GenerateID()
        {
            bool unused = default;
            string ID;
            do
            {
                ID = Guid.NewGuid().ToString();
                if (!Utilities.Utilities.ValidateID(ID))
                {
                    unused = true;
                }
            }
            while (unused);
            return ID;
        }
    }
}
