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

        // Part 10 - Welcome Message Method
        static void WelcomeMessage()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("AA Bank");
            Console.WriteLine("====================");
            Console.WriteLine("Welcome Our Bank!");
            Console.WriteLine("--------------------");
        }

        // Part 10 - Menu Method
        static void ShowMenu()
        {
            Console.WriteLine("====== BANK MENU ======");
            Console.WriteLine("1. View Account");
            Console.WriteLine("2. Check Balance");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Withdraw");
            Console.WriteLine("5. Exit");
            Console.WriteLine("========================");
        }

        // Part 10 - Account Details Method
        static void ShowAccountDetails(Account account)
        {
            Console.WriteLine("====== Account Details ======");
            Console.WriteLine($"User: {account.AccountHolder}");
            Console.WriteLine($"Account Number: {account.AccountNumber}");
            Console.WriteLine($"Balance: {account.Balance}");
            Console.WriteLine("=============================");
        }

        // Part 10 - Deposit Logic Method
        static void DepositMoney(Account account)
        {
            Console.WriteLine("Enter deposit amount:");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            account.Deposit(amount);
        }

        // Part 10 - Withdraw Logic Method
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
    }




































    //Console.WriteLine("--------------------\nAA Bank \n=================== ");
    //Console.WriteLine(".....................\nWelCome Our Bank!\n*******************");

    //string bankName = "AA Bank";
    //string accountHolder = "ravi";
    //int accountNumber = 323240;
    //decimal balance = 0m;

    //Console.WriteLine($"your account number is{accountNumber}");
    //Console.WriteLine($"Account holder name is {accountHolder}");
    //Console.WriteLine($"Your current balance is {balance}");


    //Console.WriteLine("enter your user name.");
    //string user = Convert.ToString(Console.ReadLine());


    //Console.WriteLine("enter your balance.");
    //balance = Convert.ToDecimal(Console.ReadLine());

    //Console.WriteLine($"your name is {user}");
    //Console.WriteLine($"your balance is: {balance}");

    //Console.WriteLine();
    //Console.WriteLine($"bank name: {bankName}\nuser: {user}\naccount: {accountNumber}\nbalance: {balance}\n");

    //Console.WriteLine($"user: {user}\naccount: {accountNumber}\nbalance: {balance}\n");

    //Console.WriteLine($"Decimal place Balance: {balance:F2}\n");

    //Console.WriteLine("do you want clear? press any letters key then press enter key");
    //string a = Console.ReadLine();
    //Console.Clear();


    //while (true)
    //{
    //    Console.WriteLine($"======BANK MENU========\n1.View Account\n2.Check Balance\n3.Deposit\n4.Withdraw\n5.Exit\n!!!!!!!!!!!!!!!!!!!!!!!!!\n");

    //    Console.WriteLine("Plese select your option");
    //    int option = Convert.ToInt32(Console.ReadLine());



    //    if (option > 0 && option < 6)
    //    {
    //        //use swithch
    //        //switch (option)
    //        //{
    //        //    case 1:
    //        //        Console.WriteLine("====== Account Details ======");
    //        //        Console.WriteLine($"User: {user}");
    //        //        Console.WriteLine($"Account: {accountNumber}");
    //        //        Console.WriteLine($"Balance: {balance}");
    //        //        Console.WriteLine("------------------------------");
    //        //        break;

    //        //    case 2:
    //        //        Console.WriteLine("Check Balance");
    //        //        Console.WriteLine($"Current Balance: {balance}");
    //        //        break;

    //        //    case 3:
    //        //        Console.WriteLine("Deposit");

    //        //        Console.WriteLine("Enter your deposit amount please:");
    //        //        decimal deposit = Convert.ToDecimal(Console.ReadLine());

    //        //        if (deposit > 0)
    //        //        {
    //        //            balance = balance + deposit;

    //        //            Console.WriteLine("Deposit is successful");
    //        //            Console.WriteLine($"Now balance is: {balance}");
    //        //        }
    //        //        else
    //        //        {
    //        //            Console.WriteLine("Your deposit amount is wrong");
    //        //        }
    //        //        break;

    //        //    case 4:
    //        //        Console.WriteLine("Withdraw");

    //        //        Console.WriteLine("Enter the withdraw amount please:");
    //        //        decimal withdraw = Convert.ToDecimal(Console.ReadLine());

    //        //        if (withdraw > 0)
    //        //        {
    //        //            balance = balance - withdraw;

    //        //            Console.WriteLine("Withdraw successful");
    //        //            Console.WriteLine($"Now balance is: {balance}");
    //        //        }
    //        //        else
    //        //        {
    //        //            Console.WriteLine("Invalid amount!");
    //        //        }
    //        //        break;

    //        //    case 5:
    //        //        Console.WriteLine("Exit");
    //        //        Console.Clear();
    //        //        break;

    //        //    default:
    //        //        Console.WriteLine("Invalid option!");
    //        //        break;
    //        //}
    //        //if condition
    //        if (option == 1)
    //        {
    //            Console.WriteLine("======Account Details========");
    //            Console.WriteLine($"user: {user}\naccount: {accountNumber}\nbalance: {balance}\n");
    //            Console.WriteLine("------------------------------");
    //        }
    //        else if (option == 2)
    //        {
    //            Console.WriteLine("Check Balance");
    //            Console.WriteLine($"Current Balance: {balance}");

    //        }
    //        else if (option == 3)
    //        {
    //            Console.WriteLine("Deposit");

    //            Console.WriteLine("enter your deposit amont please.");
    //            decimal deposit = Convert.ToDecimal(Console.ReadLine());
    //            if (deposit > 0)
    //            {
    //                balance = balance + deposit;

    //                Console.WriteLine("Deposit is successful");
    //                Console.WriteLine($"Now balance is : {balance}");
    //            }
    //            else
    //            {
    //                Console.WriteLine("your deosit amot is worng");
    //            }
    //        }
    //        else if (option == 4)
    //        {
    //            Console.WriteLine("Withdraw");

    //            Console.WriteLine("enter the widthraw amount please");
    //            decimal widthraw = Convert.ToDecimal(Console.ReadLine());

    //            if (widthraw > 0 && widthraw <= balance)
    //            {
    //                balance = balance - widthraw;
    //                Console.WriteLine("you widthraw is success ");
    //                Console.WriteLine($"Now balance is : {balance}");

    //            }
    //            else
    //            {
    //                Console.WriteLine("invalid amount!");
    //            }
    //        }
    //        else if (option == 5)
    //        {
    //            Console.WriteLine("Exit");

    //            Console.Clear();
    //        }


    //    }
    //    else
    //    {
    //        Console.WriteLine("your selecting invalid !");
    //    }


    //}

}
        
    

