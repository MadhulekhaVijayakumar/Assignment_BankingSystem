namespace BankSystem.Model
{
    public class SavingsAccount : Account
    {
        public float InterestRate { get; set; }
        private const float MinimumBalance = 500;

        public SavingsAccount(float balance, Customer accountHolder, float interestRate)
            : base("Savings", balance >= MinimumBalance ? balance : MinimumBalance, accountHolder)
        {
            InterestRate = interestRate;
        }

        public override void Withdraw(float amount)
        {
            if (Balance - amount >= MinimumBalance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawal successful. New balance: {Balance:F2}");
            }
            else
            {
                Console.WriteLine("Insufficient balance to maintain minimum balance.");
            }
        }
    }
}
