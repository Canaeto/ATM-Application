using System;
using System.Collections.Generic;

public class Bank
{
    private List<Account> Accounts;

    public Bank()
    {
        Accounts = new List<Account>();
        for (int i = 0; i < 10; i++)
        {
            Accounts.Add(new Account(100 + i, 100.0, 3.0, $"AccountHolder{i}"));
        }
    }

    public void AddAccount(Account account)
    {
        Accounts.Add(account);
    }

    public Account RetrieveAccount(int accountNumber)
    {
        foreach (var account in Accounts)
        {
            if (account.AccountNumber == accountNumber)
            {
                return account;
            }
        }
        return null;
    }
}
