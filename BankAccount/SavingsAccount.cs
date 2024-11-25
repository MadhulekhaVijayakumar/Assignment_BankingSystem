class SavingsAccount : BankAccount
{
    private double InterestRate;

    public SavingsAccount(string accountNumber, string customerName, double balance, double interestRate)
        : base(accountNumber, customerName, balance)
    {
        InterestRate = interestRate;
    }

    public override void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be greater than zero.");
            return;
        }
        Balance += amount;
        Console.WriteLine($"Deposited: {amount}. New Balance: {Balance}");
    }

    public override void Withdraw(double amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds.");
        }
        else if (amount <= 0)
        {
            Console.WriteLine("Withdrawal amount must be greater than zero.");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}. New Balance: {Balance}");
        }
    }

    public override double CalculateInterest()
    {
        double interest = Balance * InterestRate / 100;
        Console.WriteLine($"Calculated Interest: {interest}");
        return interest;
    }
}
