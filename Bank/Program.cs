using System;
//Task10
class BankApp
{
    static void Main(string[] args)
    {
        Bank bank = new Bank();
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
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            try
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Customer Details:");
                        Console.Write("Customer ID: ");
                        string customerId = Console.ReadLine();
                        Console.Write("First Name: ");
                        string firstName = Console.ReadLine();
                        Console.Write("Last Name: ");
                        string lastName = Console.ReadLine();
                        Console.Write("Email Address: ");
                        string email = Console.ReadLine();
                        Console.Write("Phone Number: ");
                        string phone = Console.ReadLine();
                        Console.Write("Address: ");
                        string address = Console.ReadLine();

                        Customer customer = new Customer(customerId, firstName, lastName, email, phone, address);

                        Console.Write("Enter Account Type (Savings/Current): ");
                        string accType = Console.ReadLine();
                        Console.Write("Enter Initial Balance: ");
                        float initialBalance = float.Parse(Console.ReadLine());

                        bank.CreateAccount(customer, accType, initialBalance);
                        break;

                    case 2:
                        Console.Write("Enter Account Number: ");
                        long depositAccountNumber = long.Parse(Console.ReadLine());
                        Console.Write("Enter Deposit Amount: ");
                        float depositAmount = float.Parse(Console.ReadLine());
                        bank.Deposit(depositAccountNumber, depositAmount);
                        break;

                    case 3:
                        Console.Write("Enter Account Number: ");
                        long withdrawAccountNumber = long.Parse(Console.ReadLine());
                        Console.Write("Enter Withdrawal Amount: ");
                        float withdrawAmount = float.Parse(Console.ReadLine());
                        bank.Withdraw(withdrawAccountNumber, withdrawAmount);
                        break;

                    case 4:
                        Console.Write("Enter Account Number: ");
                        long balanceAccountNumber = long.Parse(Console.ReadLine());
                        float balance = bank.GetAccountBalance(balanceAccountNumber);
                        Console.WriteLine($"Current Balance: {balance}");
                        break;

                    case 5:
                        Console.Write("Enter From Account Number: ");
                        long fromAccountNumber = long.Parse(Console.ReadLine());
                        Console.Write("Enter To Account Number: ");
                        long toAccountNumber = long.Parse(Console.ReadLine());
                        Console.Write("Enter Transfer Amount: ");
                        float transferAmount = float.Parse(Console.ReadLine());
                        bank.Transfer(fromAccountNumber, toAccountNumber, transferAmount);
                        break;

                    case 6:
                        Console.Write("Enter Account Number: ");
                        long detailsAccountNumber = long.Parse(Console.ReadLine());
                        bank.GetAccountDetails(detailsAccountNumber);
                        break;

                    case 7:
                        exit = true;
                        Console.WriteLine("Exiting the system. Thank you!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
