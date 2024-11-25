using System;

class Account
{
    // Attributes
    public string AccountNumber { get; set; }
    public string AccountType { get; set; }
    public double AccountBalance { get; set; }
    public Customer AccountHolder { get; set; }

    // Default Constructor
    public Account()
    {
        AccountNumber = string.Empty;
        AccountType = string.Empty;
        AccountBalance = 0.0;
        AccountHolder = null;
    }

    // Overloaded Constructor
    public Account(string accountNumber, string accountType, double accountBalance, Customer accountHolder)
    {
        AccountNumber = accountNumber;
        AccountType = accountType;
        AccountBalance = accountBalance;
        AccountHolder = accountHolder;
    }

    // Methods
    public void PrintInfo()
    {
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Account Type: {AccountType}");
        Console.WriteLine($"Account Balance: {AccountBalance:F2}");
        Console.WriteLine("Account Holder Information:");
        AccountHolder?.PrintInfo();
    }
}
