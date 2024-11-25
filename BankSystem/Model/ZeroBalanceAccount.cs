namespace BankSystem.Model
{
    public class ZeroBalanceAccount : Account
    {
        public ZeroBalanceAccount(Customer accountHolder)
            : base("Zero Balance", 0, accountHolder)
        {
        }

        public override void Withdraw(float amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawal successful. New balance: {Balance:F2}");
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
    }
}
