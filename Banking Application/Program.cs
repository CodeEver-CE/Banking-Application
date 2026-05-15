namespace Banking_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();

            string bankName = "AA Bank";

            Console.WriteLine("Enter your user name:");
            string user = Console.ReadLine();

            Console.WriteLine("Enter your opening balance:");
            decimal balance = Convert.ToDecimal(Console.ReadLine());

            int accountNumber = 323240;

            // Create BankAccount Object
            Account account = new Account(user, accountNumber, balance);

            Console.WriteLine();
            Console.WriteLine($"Bank Name: {bankName}");
            Console.WriteLine($"User: {account.AccountHolder}");
            Console.WriteLine($"Account Number: {account.AccountNumber}");
            Console.WriteLine($"Balance: {account.Balance:F2}");

            Console.WriteLine();
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

            Console.Clear();

            while (true)
            {
                // Menu Method
                ShowMenu();

                Console.WriteLine("Please select your option:");
                int option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    // Account Details Method
                    ShowAccountDetails(account);
                }
                else if (option == 2)
                {
                    Console.WriteLine($"Current Balance: {account.Balance}");
                }
                else if (option == 3)
                {
                    // Deposit
                    DepositMoney(account);
                }
                else if (option == 4)
                {
                    // Withdraw
                    WithdrawMoney(account);
                }
                else if (option == 5)
                {
                    // Withdraw
                    ShowTransactions(account);
                }
                else if (option == 6)
                {
                    Console.WriteLine("Thank you for using AA Bank");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option!");
                }

                Console.WriteLine();
            }
        }

        // Welcome Message Method
        static void WelcomeMessage()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("AA Bank");
            Console.WriteLine("====================");
            Console.WriteLine("Welcome Our Bank!");
            Console.WriteLine("--------------------");
        }

        // Menu Method
        static void ShowMenu()
        {
            Console.WriteLine("====== BANK MENU ======");
            Console.WriteLine("1. View Account");
            Console.WriteLine("2. Check Balance");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Withdraw");
            Console.WriteLine("5. Transaction History");
            Console.WriteLine("6. Exit");
            Console.WriteLine("========================");
        }

        // Account Details Method
        static void ShowAccountDetails(Account account)
        {
            Console.WriteLine("====== Account Details ======");
            Console.WriteLine($"User: {account.AccountHolder}");
            Console.WriteLine($"Account Number: {account.AccountNumber}");
            Console.WriteLine($"Balance: {account.Balance}");
            Console.WriteLine("=============================");
        }

        // Deposit Logic Method
        static void DepositMoney(Account account)
        {
            Console.WriteLine("Enter deposit amount:");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            account.Deposit(amount);
        }

        //  Withdraw Logic Method
        static void WithdrawMoney(Account account)
        {
            Console.WriteLine("Enter withdraw amount:");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            bool success = account.Withdraw(amount);

            if (success)
            {
                Console.WriteLine("Withdraw successful");
                Console.WriteLine($"Current Balance: {account.Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient balance or invalid amount");
            }
        }

        //Transaction Method

        static void ShowTransactions(Account account)
        {
            Console.WriteLine("========Transaction Histroy========");

            if (account.Transactions.Count == 0)
            {
                Console.WriteLine("No transactions");


            }
            else
            {
                foreach (string transaction in account.Transactions)
                {
                    Console.WriteLine(transaction);
                }
            }
            Console.WriteLine("====================================");
        }
    }    

}
        
    

