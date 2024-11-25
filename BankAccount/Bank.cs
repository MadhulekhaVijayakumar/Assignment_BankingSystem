using System;

class Bank
{
    private BankAccount account;

    // Method to create an account
    public void CreateAccount()
    {
        Console.WriteLine("Choose Account Type to Create:");
        Console.WriteLine("1. Savings Account");
        Console.WriteLine("2. Current Account");
        Console.Write("Enter your choice (1/2): ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Enter Account Number: ");
                string saAccountNumber = Console.ReadLine();
                Console.Write("Enter Customer Name: ");
                string saCustomerName = Console.ReadLine();
                Console.Write("Enter Initial Balance: ");
                double saBalance = double.Parse(Console.ReadLine());
                Console.Write("Enter Interest Rate (%): ");
                double saInterestRate = double.Parse(Console.ReadLine());

                account = new SavingsAccount(saAccountNumber, saCustomerName, saBalance, saInterestRate);
                Console.WriteLine("Savings Account Created Successfully!");
                break;

            case 2:
                Console.Write("Enter Account Number: ");
                string caAccountNumber = Console.ReadLine();
                Console.Write("Enter Customer Name: ");
                string caCustomerName = Console.ReadLine();
                Console.Write("Enter Initial Balance: ");
                double caBalance = double.Parse(Console.ReadLine());

                account = new CurrentAccount(caAccountNumber, caCustomerName, caBalance);
                Console.WriteLine("Current Account Created Successfully!");
                break;

            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }

    // Method to deposit amount
    public void Deposit()
    {
        Console.Write("Enter deposit amount: ");
        double amount = double.Parse(Console.ReadLine());
        account.Deposit(amount);
    }

    // Method to withdraw amount
    public void Withdraw()
    {
        Console.Write("Enter withdrawal amount: ");
        double amount = double.Parse(Console.ReadLine());
        account.Withdraw(amount);
    }

    // Method to calculate interest
    public void CalculateInterest()
    {
        if (account is SavingsAccount savingsAccount)
        {
            double interest = savingsAccount.CalculateInterest();
            savingsAccount.Deposit(interest);
            Console.WriteLine("Interest added to balance.");
        }
        else
        {
            Console.WriteLine("No interest applicable for Current Account.");
        }
    }

    // Method to print account information
    public void PrintAccountInfo()
    {
        account.PrintInfo();
    }
}
