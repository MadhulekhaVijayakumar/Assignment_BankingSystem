using System;
using System.Collections.Generic;

class Bank
{
    private Dictionary<long, Account> accounts = new Dictionary<long, Account>();
    private long nextAccountNumber = 1001;

    // Create a new bank account
    public void CreateAccount(Customer customer, string accType, float initialBalance)
    {
        long accountNumber = nextAccountNumber++;
        Account newAccount = new Account(accountNumber.ToString(), accType, initialBalance, customer);
        accounts[accountNumber] = newAccount;
        Console.WriteLine($"Account successfully created with Account Number: {accountNumber}");
    }

    // Get account balance
    public float GetAccountBalance(long accountNumber)
    {
        if (accounts.TryGetValue(accountNumber, out var account))
        {
            return (float)account.AccountBalance;
        }
        else
        {
            throw new ArgumentException("Account number not found.");
        }
    }

    // Deposit amount
    public float Deposit(long accountNumber, float amount)
    {
        if (accounts.TryGetValue(accountNumber, out var account))
        {
            account.AccountBalance += amount;
            Console.WriteLine($"Deposited {amount}. Current balance: {account.AccountBalance}");
            return (float)account.AccountBalance;
        }
        else
        {
            throw new ArgumentException("Account number not found.");
        }
    }

    // Withdraw amount
    public float Withdraw(long accountNumber, float amount)
    {
        if (accounts.TryGetValue(accountNumber, out var account))
        {
            if (account.AccountBalance >= amount)
            {
                account.AccountBalance -= amount;
                Console.WriteLine($"Withdrawn {amount}. Current balance: {account.AccountBalance}");
                return (float)account.AccountBalance;
            }
            else
            {
                throw new InvalidOperationException("Insufficient balance.");
            }
        }
        else
        {
            throw new ArgumentException("Account number not found.");
        }
    }

    // Transfer money between accounts
    public void Transfer(long fromAccountNumber, long toAccountNumber, float amount)
    {
        if (!accounts.ContainsKey(fromAccountNumber) || !accounts.ContainsKey(toAccountNumber))
        {
            throw new ArgumentException("One or both account numbers are invalid.");
        }

        Withdraw(fromAccountNumber, amount);
        Deposit(toAccountNumber, amount);
        Console.WriteLine($"Transferred {amount} from {fromAccountNumber} to {toAccountNumber}.");
    }

    // Get account and customer details
    public void GetAccountDetails(long accountNumber)
    {
        if (accounts.TryGetValue(accountNumber, out var account))
        {
            Console.WriteLine("\nAccount Details:");
            account.PrintInfo();
        }
        else
        {
            throw new ArgumentException("Account number not found.");
        }
    }
}
