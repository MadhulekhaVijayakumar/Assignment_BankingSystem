using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystem.Model;

namespace BankSystem.Service
{
    public class BankServiceProviderImpl : CustomerServiceProviderImpl, IBankServiceProvider
    {
            public string BranchName { get; set; }
            public string BranchAddress { get; set; }

            public BankServiceProviderImpl(string branchName, string branchAddress)
            {
                BranchName = branchName;
                BranchAddress = branchAddress;
            }

            public void CreateAccount(Customer customer, string accType, float balance)
            {
                Account account = accType switch
                {
                    "Savings" => new SavingsAccount(balance, customer, 0.04f),
                    "Current" => new CurrentAccount(balance, customer, 1000),
                    "ZeroBalance" => new ZeroBalanceAccount(customer),
                    _ => throw new ArgumentException("Invalid account type.")
                };

                accounts.Add(account);
                Console.WriteLine($"Account created: {account.AccountNumber}");
            }

            public void ListAccounts()
            {
                foreach (var account in accounts)
                {
                    account.PrintAccountDetails();
                }
            }

            public void CalculateInterest()
            {
                foreach (var account in accounts)
                {
                    if (account is SavingsAccount savingsAccount)
                    {
                        float interest = savingsAccount.Balance * savingsAccount.InterestRate;
                        savingsAccount.Balance += interest;
                        Console.WriteLine($"Interest added to account {savingsAccount.AccountNumber}: {interest:F2}");
                    }
                }
            }
        
    }
}
