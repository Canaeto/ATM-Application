using System;

public class AtmApplication
{
    private Bank bank;

    public AtmApplication()
    {
        bank = new Bank();
    }

    public void Run()
    {
        while (true)
        {
            DisplayMainMenu();
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    CreateAccount();
                    break;
                case 2:
                    SelectAccount();
                    break;
                case 3:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private void DisplayMainMenu()
    {
        Console.WriteLine("ATM Main Menu");
        Console.WriteLine("1. Create Account");
        Console.WriteLine("2. Select Account");
        Console.WriteLine("3. Exit");
    }

    private void CreateAccount()
    {
        Console.WriteLine("Enter account number:");
        int accountNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter initial balance:");
        double initialBalance = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter interest rate:");
        double interestRate = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter account holder's name:");
        string accountHolderName = Console.ReadLine();

        Account newAccount = new Account(accountNumber, initialBalance, interestRate, accountHolderName);
        bank.AddAccount(newAccount);
        Console.WriteLine("Account created successfully.");
    }

    private void SelectAccount()
    {
        Console.WriteLine("Enter account number:");
        int accountNumber = int.Parse(Console.ReadLine());

        Account account = bank.RetrieveAccount(accountNumber);
        if (account != null)
        {
            while (true)
            {
                DisplayAccountMenu();
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        account.DisplayBalance();
                        break;
                    case 2:
                        Console.WriteLine("Enter amount to deposit:");
                        double depositAmount = double.Parse(Console.ReadLine());
                        account.Deposit(depositAmount);
                        break;
                    case 3:
                        Console.WriteLine("Enter amount to withdraw:");
                        double withdrawAmount = double.Parse(Console.ReadLine());
                        account.Withdraw(withdrawAmount);
                        break;
                    case 4:
                        account.DisplayTransactions();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                
            }
        }
        else
        {
            Console.WriteLine("Account not found.");

        }
    }

    private void DisplayAccountMenu()
    {
        Console.WriteLine("Account Menu");
        Console.WriteLine("1. Check Balance");
        Console.WriteLine("2. Deposit");
        Console.WriteLine("3. Withdraw");
        Console.WriteLine("4. Display Transactions");
        Console.WriteLine("5. Exit Account");
    }
}
