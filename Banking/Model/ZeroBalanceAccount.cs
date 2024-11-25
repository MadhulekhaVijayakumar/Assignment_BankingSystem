namespace BankingSystem.Model
{
    public class ZeroBalanceAccount : Account
    {
        public ZeroBalanceAccount(double balance, Customer customer)
            : base("ZeroBalance", balance, customer)
        {
        }

        public override void Withdraw(double amount)
        {
            if (Balance - amount < 0)
                throw new InvalidOperationException("Cannot withdraw. Insufficient balance.");
            Balance -= amount;
        }
    }
}
