namespace ObjectsandClass.Model
{
    internal class CurrentAccount : Account
    {
        private const float OverdraftLimit = 5000.0f;

        // Constructor for CurrentAccount
        public CurrentAccount(int accountNumber, string accountType, float accountBalance)
            : base(accountNumber, accountType, accountBalance)
        {

        }

        // Override withdraw method to allow overdraft
        public override void Withdraw(float amount)
        {
            if (amount > 0)
            {
                if (AccountBalance - amount >= -OverdraftLimit)
                {
                    AccountBalance -= amount;
                    Console.WriteLine($"Withdrew {amount:C}. New Balance: {AccountBalance:C}");
                }
                else
                {
                    Console.WriteLine("Overdraft limit exceeded. Transaction denied.");
                }
            }
            else
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
            }
        }
    }
}
