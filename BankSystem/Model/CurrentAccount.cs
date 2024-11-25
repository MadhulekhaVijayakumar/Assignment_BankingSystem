namespace BankSystem.Model
{
    public class CurrentAccount : Account
    {
        public float OverdraftLimit { get; set; }

        public CurrentAccount(float balance, Customer accountHolder, float overdraftLimit)
            : base("Current", balance, accountHolder)
        {
            OverdraftLimit = overdraftLimit;
        }

        public override void Withdraw(float amount)
        {
            if (Balance - amount >= -OverdraftLimit)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawal successful. New balance: {Balance:F2}");
            }
            else
            {
                Console.WriteLine("Exceeded overdraft limit.");
            }
        }
    }
}
