using System;
using BankSystem.Exception;
using BankSystem.Model;
using BankSystem.Service;


namespace app
{
    class BankApp
    {
        static void Main(string[] args)
        {
            BankServiceProviderImpl bank = new BankServiceProviderImpl("My Bank", "123 Bank Street");
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n=== Banking System Menu ===");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Get Balance");
                Console.WriteLine("5. Transfer");
                Console.WriteLine("6. Get Account Details");
                Console.WriteLine("7. List All Accounts");
                Console.WriteLine("8. Exit");
                Console.Write("Enter your choice: ");

                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter Customer ID: ");
                            string customerId = Console.ReadLine();
                            Console.Write("Enter First Name: ");
                            string firstName = Console.ReadLine();
                            Console.Write("Enter Last Name: ");
                            string lastName = Console.ReadLine();
                            Console.Write("Enter Email: ");
                            string email = Console.ReadLine();
                            Console.Write("Enter Phone: ");
                            string phone = Console.ReadLine();
                            Console.Write("Enter Address: ");
                            string address = Console.ReadLine();
                            Console.Write("Enter Account Type (Savings/Current/ZeroBalance): ");
                            string accType = Console.ReadLine();
                            Console.Write("Enter Initial Balance: ");
                            float balance = float.Parse(Console.ReadLine());

                            Customer customer = new Customer(customerId, firstName, lastName, email, phone, address);
                            bank.CreateAccount(customer, accType, balance);
                            break;

                        case 2:
                            Console.Write("Enter Account Number: ");
                            long accNoDeposit = long.Parse(Console.ReadLine());
                            Console.Write("Enter Amount to Deposit: ");
                            float depositAmount = float.Parse(Console.ReadLine());
                            float newBalance = bank.Deposit(accNoDeposit, depositAmount);
                            Console.WriteLine($"New Balance: {newBalance:F2}");
                            break;

                        case 3:
                            Console.Write("Enter Account Number: ");
                            long accNoWithdraw = long.Parse(Console.ReadLine());
                            Console.Write("Enter Amount to Withdraw: ");
                            float withdrawAmount = float.Parse(Console.ReadLine());
                            bank.Withdraw(accNoWithdraw, withdrawAmount);
                            break;

                        case 4:
                            Console.Write("Enter Account Number: ");
                            long accNoBalance = long.Parse(Console.ReadLine());
                            float balanceAmount = bank.GetAccountBalance(accNoBalance);
                            Console.WriteLine($"Current Balance: {balanceAmount:F2}");
                            break;

                        case 5:
                            Console.Write("Enter From Account Number: ");
                            long fromAccNo = long.Parse(Console.ReadLine());
                            Console.Write("Enter To Account Number: ");
                            long toAccNo = long.Parse(Console.ReadLine());
                            Console.Write("Enter Amount to Transfer: ");
                            float transferAmount = float.Parse(Console.ReadLine());
                            bank.Transfer(fromAccNo, toAccNo, transferAmount);
                            break;

                        case 6:
                            Console.Write("Enter Account Number: ");
                            long accNoDetails = long.Parse(Console.ReadLine());
                            bank.GetAccountDetails(accNoDetails);
                            break;

                        case 7:
                            bank.ListAccounts();
                            break;

                        case 8:
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                catch (InvalidAccountException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (InsufficientFundException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (OverDraftLimitExceededException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("Error: An unexpected null reference occurred.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }

            Console.WriteLine("Thank you for using the Banking System. Goodbye!");
        }
    }
}
