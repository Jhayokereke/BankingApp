﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task2Solution
{
    public class Customer: ICustomer
    {
        public Customer()
        {
            ID = Guid.NewGuid().ToString();
            UserAccounts = new List<CurrentAccount>();
        }
        public string Name { get; set; }

        public string Email { get; set; }

        public string ID { get; set; }

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public List<CurrentAccount> UserAccounts { get; set; }
    }
}