using System;

namespace BankingSystem.Model
{
    public class Transaction
    {
        public Account Account { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; private set; }
        public string TransactionType { get; set; }
        public double TransactionAmount { get; set; }

        public Transaction(Account account, string description, string transactionType, double transactionAmount)
        {
            Account = account;
            Description = description;
            DateTime = DateTime.Now;
            TransactionType = transactionType;
            TransactionAmount = transactionAmount;
        }

        public override string ToString()
        {
            return $"Transaction: [Account: {Account.AccountNumber}, Type: {TransactionType}, Amount: {TransactionAmount}, Date: {DateTime}, Description: {Description}]";
        }
    }
}
