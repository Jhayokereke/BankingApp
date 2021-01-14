using System;
using System.Collections.Generic;
using System.Text;

namespace Task2Solution.core
{
    class CustomerRepository
    {
        private AccountRepository _accountRepository;

        //constructor
        public CustomerRepository()
        {
            _accountRepository = new AccountRepository();
        }

        //get customer by email
        public Customer GetCustomerByEmail(string email)
        {
            //code goes here

        }

        //get customer by account
        public Customer GetCustomerByAccount(string accountnumber)
        {
            //code goes here
        }

        //update customer details
        public Customer UpdateCustomer(string email)
        {
            //code goes here
        }

    }
}
