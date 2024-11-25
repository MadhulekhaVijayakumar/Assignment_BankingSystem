namespace ObjectsandClass.Model
{
    internal class SavingsAccount : Account
    {
        public float InterestRate { get; set; }

        // Constructor for SavingsAccount
        public SavingsAccount(int accountNumber, string accountType, float accountBalance, float interestRate)
            : base(accountNumber, accountType, accountBalance)
        {
            InterestRate = interestRate;
        }

        // Override calculate_interest method
        public override void CalculateInterest()
        {
            float interest = AccountBalance * (InterestRate / 100);
            Console.WriteLine($"Interest at {InterestRate}% rate: {interest:C}");
        }

        // Method to Print Account Information
        public new void PrintAccountInfo()
        {
            base.PrintAccountInfo();
            Console.WriteLine($"Interest Rate: {InterestRate}%");
        }
    }
}
