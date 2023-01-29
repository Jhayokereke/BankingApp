using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApp.Models
{
    public interface ICustomer
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string ID { get; set; }

        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public List<IAccount> CustomerAccounts { get; set; }
    }
}
