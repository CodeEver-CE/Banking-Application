using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Banking_Application
{
    class Account
    {
        // Properties
        public string AccountHolder { get; set; }
        public int AccountNumber { get; set; }

        //Add Transactions

        public List<string> Transactions { get; set; }

        // Protected Balance
        public decimal Balance { get; private set; }

        // Constructor
        public Account(string accountHolder, int accountNumber, decimal balance)
        {
            AccountHolder = accountHolder;
            AccountNumber = accountNumber;
            Balance = balance;
            Transactions = new List<string>();
        }

        //  Deposit Method
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;

                Transactions.Add($"Deposite: {amount}");
                Console.WriteLine("Deposit successful");
                Console.WriteLine($"Current Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount");
            }
        }

        //  Withdraw Method
        public bool Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;

                Transactions.Add($"Withdraw: {amount}");
                return true;
            }
            
            return false;
        }
    }
}
