using System;

abstract class BankAccount
{
    // Attributes
    public string AccountNumber { get; set; }
    public string CustomerName { get; set; }
    public double Balance { get; set; }

    // Default Constructor
    protected BankAccount()
    {
        AccountNumber = string.Empty;
        CustomerName = string.Empty;
        Balance = 0.0;
    }

    // Overloaded Constructor
    protected BankAccount(string accountNumber, string customerName, double balance)
    {
        AccountNumber = accountNumber;
        CustomerName = customerName;
        Balance = balance;
    }

    // Print all information
    public void PrintInfo()
    {
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Customer Name: {CustomerName}");
        Console.WriteLine($"Balance: {Balance:F2}");
    }

    // Abstract methods
    public abstract void Deposit(double amount);
    public abstract void Withdraw(double amount);
    public abstract double CalculateInterest();
}
