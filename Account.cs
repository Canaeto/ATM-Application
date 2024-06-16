using System;
using System.Collections.Generic;

public class Account
{
    public int AccountNumber { get; set; }
    public double Balance { get; private set; }
    public double InterestRate { get; set; }
    public string AccountHolderName { get; set; }
    private List<string> Transactions { get; set; }

    public Account(int accountNumber, double initialBalance, double interestRate, string accountHolderName)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
        InterestRate = interestRate;
        AccountHolderName = accountHolderName;
        Transactions = new List<string>();
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        Transactions.Add($"Deposited: ${amount}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            Transactions.Add($"Withdrew: ${amount}");
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }

    public void DisplayTransactions()
    {
        Console.WriteLine("Transactions:");
        foreach (var transaction in Transactions)
        {
            Console.WriteLine(transaction);
        }
    }

    public void DisplayBalance()
    {
        Console.WriteLine($"Balance: ${Balance}");
    }
}
