using System;
using System.Collections.Generic;
using BankSystem.Exception;
using BankSystem.Model;

namespace BankSystem.Service
{
    public class CustomerServiceProviderImpl : ICustomerServiceProvider
    {
        protected List<Account> accounts = new List<Account>();

        public float GetAccountBalance(long accountNumber)
        {
            Account account = FindAccount(accountNumber);
            if (account == null)
                throw new InvalidAccountException("Account not found.");
            return account.Balance;
        }

        public float Deposit(long accountNumber, float amount)
        {
            Account account = FindAccount(accountNumber);
            if (account == null)
                throw new InvalidAccountException("Account not found.");
            account.Balance += amount;
            return account.Balance;
        }

        public void Withdraw(long accountNumber, float amount)
        {
            Account account = FindAccount(accountNumber);
            if (account == null)
                throw new InvalidAccountException("Account not found.");

            switch (account)
            {
                case SavingsAccount savings when (savings.Balance - amount < 500):
                    throw new InsufficientFundException("Insufficient funds to maintain minimum balance.");
                case CurrentAccount current when (current.Balance - amount < -current.OverdraftLimit):
                    throw new OverDraftLimitExceededException("Overdraft limit exceeded.");
                default:
                    if (account.Balance < amount)
                        throw new InsufficientFundException("Insufficient funds in the account.");
                    account.Balance -= amount;
                    break;
            }
        }

        public void Transfer(long fromAccountNumber, long toAccountNumber, float amount)
        {
            Withdraw(fromAccountNumber, amount);
            Deposit(toAccountNumber, amount);
        }

        public void GetAccountDetails(long accountNumber)
        {
            Account account = FindAccount(accountNumber);
            if (account == null)
                throw new InvalidAccountException("Account not found.");
            account.PrintAccountDetails();
        }

        protected Account FindAccount(long accountNumber)
        {
            return accounts.Find(acc => acc.AccountNumber == accountNumber);
        }
    }
}
