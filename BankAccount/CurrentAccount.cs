using System;

class CurrentAccount : BankAccount
{
    private const double OverdraftLimit = 1000.0;

    public CurrentAccount(string accountNumber, string customerName, double balance)
        : base(accountNumber, customerName, balance)
    {
    }

    public override void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be greater than zero.");
            return;
        }
        Balance += amount;
        Console.WriteLine($"Deposited: {amount:F2}. New Balance: {Balance:F2}");
    }

    public override void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal amount must be greater than zero.");
        }
        else if (Balance - amount < -OverdraftLimit)
        {
            Console.WriteLine($"Withdrawal denied. Overdraft limit of {OverdraftLimit:F2} exceeded.");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn: {amount:F2}. New Balance: {Balance:F2}");
        }
    }

    public override double CalculateInterest()
    {
        Console.WriteLine("No interest for Current Account.");
        return 0.0;
    }
}
