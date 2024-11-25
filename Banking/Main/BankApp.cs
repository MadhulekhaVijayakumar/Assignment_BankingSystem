using BankingSystem.Model;
using BankingSystem.Service;
using BankingSystem.Repository;
using BankingSystem.Exceptions;
using System;

namespace BankingSystem.App
{
    public class BankApp
    {
        private readonly IBankService _bankService;

        public BankApp()
        {
            // Directly create repository and service instances
            var bankRepository = new BankRepositoryImpl();
            _bankService = new BankServiceImpl(bankRepository);
        }

        public void Run()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nWelcome to the Banking System!");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Transfer");
                Console.WriteLine("5. Get Balance");
                Console.WriteLine("6. Get Account Details");
                Console.WriteLine("7. Exit");
                Console.Write("Choose an option: ");
                var choice = Console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            CreateAccount();
                            break;
                        case "2":
                            Deposit();
                            break;
                        case "3":
                            Withdraw();
                            break;
                        case "4":
                            Transfer();
                            break;
                        case "5":
                            GetBalance();
                            break;
                        case "6":
                            GetAccountDetails();
                            break;
                        case "7":
                            running = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice, please try again.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        private void CreateAccount()
        {
            Console.Write("Enter Customer ID: ");
            int customerId = int.Parse(Console.ReadLine());

            Console.Write("Enter Account Type (Savings/Current): ");
            string accountType = Console.ReadLine();

            Console.Write("Enter Initial Balance: ");
            decimal balance = decimal.Parse(Console.ReadLine());

            var customer = new Customer { CustomerID = customerId };

            var accountNumber = _bankService.CreateAccount(customer, accountType, balance);

            Console.WriteLine($"Account created successfully! Account Number: {accountNumber}");
        }

        private void Deposit()
        {
            Console.Write("Enter Account Number: ");
            long accountNumber = long.Parse(Console.ReadLine());

            Console.Write("Enter Deposit Amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            var newBalance = _bankService.Deposit(accountNumber, amount);
            Console.WriteLine($"Deposited successfully! New Balance: {newBalance}");
        }

        private void Withdraw()
        {
            Console.Write("Enter Account Number: ");
            long accountNumber = long.Parse(Console.ReadLine());

            Console.Write("Enter Withdrawal Amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            try
            {
                var newBalance = _bankService.Withdraw(accountNumber, amount);
                Console.WriteLine($"Withdrawn successfully! New Balance: {newBalance}");
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void Transfer()
        {
            Console.Write("Enter From Account Number: ");
            long fromAccountNumber = long.Parse(Console.ReadLine());

            Console.Write("Enter To Account Number: ");
            long toAccountNumber = long.Parse(Console.ReadLine());

            Console.Write("Enter Transfer Amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            try
            {
                bool success = _bankService.Transfer(fromAccountNumber, toAccountNumber, amount);
                if (success)
                    Console.WriteLine("Transfer successful!");
                else
                    Console.WriteLine("Transfer failed due to insufficient balance.");
            }
            catch (InvalidAccountException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        private void GetBalance()
        {
            Console.Write("Enter Account Number: ");
            long accountNumber = long.Parse(Console.ReadLine());

            var balance = _bankService.GetAccountBalance(accountNumber);
            Console.WriteLine($"Account Balance: {balance}");
        }

        private void GetAccountDetails()
        {
            Console.Write("Enter Account Number: ");
            long accountNumber = long.Parse(Console.ReadLine());

            var account = _bankService.GetAccountDetails(accountNumber);
            if (account != null)
            {
                Console.WriteLine($"Account Number: {account.AccountNumber}");
                Console.WriteLine($"Account Type: {account.AccountType}");
                Console.WriteLine($"Account Balance: {account.AccountBalance}");
                Console.WriteLine($"Customer ID: {account.CustomerID}");
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }
    }
}
