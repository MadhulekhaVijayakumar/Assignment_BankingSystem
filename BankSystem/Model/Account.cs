using System;

namespace BankSystem.Model
{
    public abstract class Account
    {
        private static long lastAccNo = 1000;

        public long AccountNumber { get; private set; }
        public string AccountType { get; set; }
        public float Balance { get; set; }
        public Customer AccountHolder { get; set; }

        protected Account(string accountType, float balance, Customer accountHolder)
        {
            AccountNumber = ++lastAccNo;
            AccountType = accountType;
            Balance = balance;
            AccountHolder = accountHolder;
        }

        public abstract void Withdraw(float amount);

        public virtual void PrintAccountDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}, Type: {AccountType}, Balance: {Balance:F2}");
            AccountHolder.PrintInfo();
        }
    }
}
