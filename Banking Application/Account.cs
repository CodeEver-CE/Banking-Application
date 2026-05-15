using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Application
{
    class Account
    {
        // Properties
        public string AccountHolder { get; set; }
        public int AccountNumber { get; set; }

        // Protected Balance
        public decimal Balance { get; private set; }

        // Constructor
        public Account(string accountHolder, int accountNumber, decimal balance)
        {
            AccountHolder = accountHolder;
            AccountNumber = accountNumber;
            Balance = balance;
        }

        // Part 12 - Deposit Method
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine("Deposit successful");
                Console.WriteLine($"Current Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount");
            }
        }

        // Part 12 - Withdraw Method
        public bool Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                return true;
            }
            
            return false;
        }
    }
}
