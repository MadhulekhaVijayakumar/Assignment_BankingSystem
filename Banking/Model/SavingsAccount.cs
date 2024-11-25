namespace BankingSystem.Model
{
    public class SavingsAccount : Account
    {
        private const double MinimumBalance = 500;
        public double InterestRate { get; set; }

        public SavingsAccount(double interestRate, double balance, Customer customer)
            : base("Savings", balance, customer)
        {
            if (balance < MinimumBalance)
                throw new ArgumentException($"Minimum balance for Savings Account is {MinimumBalance}.");
            InterestRate = interestRate;
        }

        public override void Withdraw(double amount)
        {
            if (Balance - amount < MinimumBalance)
                throw new InvalidOperationException("Cannot withdraw below minimum balance.");
            Balance -= amount;
        }
    }
}
