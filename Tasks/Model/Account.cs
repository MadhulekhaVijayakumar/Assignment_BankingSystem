namespace ObjectsandClass.Model
{
    internal class Account
    {
        public int AccountNumber { get; set; }
        public string AccountType { get; set; }
        public float AccountBalance { get; protected set; }

        //Default constructor
        public Account()
        {
            AccountNumber = 10125;
            AccountType = "Savings";
            AccountBalance = 10000.0f;
        }

        //Parameterized constructor
        public Account(int accountNumber, string accountType, float accountBalance)
        {
            AccountNumber = accountNumber;
            AccountType = accountType;
            AccountBalance = accountBalance;
        }

        //Method to print information
        public void PrintAccountInfo()
        {
            Console.WriteLine("Account Information:");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Type: {AccountType}");
            Console.WriteLine($"Account Balance: {AccountBalance}");
            Console.WriteLine();
        }
        //Overload deposit method
        public void Deposit(float amount)
        {
            UpdateBalance(amount);
        }

        public void Deposit(int amount)
        {
            UpdateBalance(amount);
        }

        public void Deposit(double amount)
        {
            UpdateBalance((float)amount);
        }

        // Overloaded Withdraw method
        public virtual void Withdraw(float amount)
        {
            TryWithdraw(amount);
        }

        public void Withdraw(int amount)
        {
            TryWithdraw(amount);
        }

        public void Withdraw(double amount)
        {
            TryWithdraw((float)amount);
        }

        //Deposit
        public void UpdateBalance(float amount)
        {
            if (amount > 0)
            {
                AccountBalance += amount;
                Console.WriteLine($"Deposited {amount}.\n New Balance: {AccountBalance}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
            }
        }

        //Withdraw
        public void TryWithdraw(float amount)
        {
            if (amount > 0)
            {
                if (AccountBalance >= amount)
                {
                    AccountBalance -= amount;
                    Console.WriteLine($"Withdrew {amount}. New Balance: {AccountBalance}");
                }
                else
                {
                    Console.WriteLine("Insufficient balance.");
                }
            }
            else
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
            }
        }

        //Interest
        public virtual void CalculateInterest()
        {
            const float interestRate = 4.5f / 100;
            float interest = AccountBalance * interestRate;
            Console.WriteLine("Interest amount for the available balance: ");
            Console.WriteLine($"Interest :{interest}");
        }
    }
}
