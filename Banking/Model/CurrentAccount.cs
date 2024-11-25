namespace BankingSystem.Model
{
    public class CurrentAccount : Account
    {
        public double OverdraftLimit { get; set; }

        public CurrentAccount(double overdraftLimit, double balance, Customer customer)
            : base("Current", balance, customer)
        {
            OverdraftLimit = overdraftLimit;
        }

        public override void Withdraw(double amount)
        {
            if (Balance - amount < -OverdraftLimit)
                throw new InvalidOperationException("Withdrawal exceeds overdraft limit.");
            Balance -= amount;
        }
    }
}
