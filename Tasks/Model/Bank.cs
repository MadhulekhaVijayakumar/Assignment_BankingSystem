namespace ObjectsandClass.Model
{
    internal class Bank
    {
        public void StartBanking()
        {
            Account account = null;

            while (true)
            {
                Console.WriteLine("\nWelcome to the Banking System!");
                Console.WriteLine("1. Create Savings Account");
                Console.WriteLine("2. Create Current Account");
                Console.WriteLine("3. Deposit Amount");
                Console.WriteLine("4. Withdraw Amount");
                Console.WriteLine("5. Calculate Interest (Savings Account Only)");
                Console.WriteLine("6. Display Account Information");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Create a Savings Account
                        Console.Write("Enter Account Number: ");
                        int savingsAccountNumber = int.Parse(Console.ReadLine());
                        Console.Write("Enter Initial Balance: ");
                        float savingsBalance = float.Parse(Console.ReadLine());
                        Console.Write("Enter Interest Rate: ");
                        float interestRate = float.Parse(Console.ReadLine());

                        account = new SavingsAccount(savingsAccountNumber, "Savings", savingsBalance, interestRate);
                        Console.WriteLine("Savings Account Created Successfully!");
                        break;

                    case 2:
                        // Create a Current Account
                        Console.Write("Enter Account Number: ");
                        int currentAccountNumber = int.Parse(Console.ReadLine());
                        Console.Write("Enter Initial Balance: ");
                        float currentBalance = float.Parse(Console.ReadLine());

                        account = new CurrentAccount(currentAccountNumber, "Current", currentBalance);
                        Console.WriteLine("Current Account Created Successfully!");
                        break;

                    case 3:
                        // Deposit Amount
                        if (account == null)
                        {
                            Console.WriteLine("Please create an account first!");
                        }
                        else
                        {
                            Console.Write("Enter Deposit Amount: ");
                            float depositAmount = float.Parse(Console.ReadLine());
                            account.Deposit(depositAmount);
                        }
                        break;

                    case 4:
                        // Withdraw Amount
                        if (account == null)
                        {
                            Console.WriteLine("Please create an account first!");
                        }
                        else
                        {
                            Console.Write("Enter Withdrawal Amount: ");
                            float withdrawalAmount = float.Parse(Console.ReadLine());
                            account.Withdraw(withdrawalAmount);
                        }
                        break;

                    case 5:
                        // Calculate Interest for Savings Account
                        if (account is SavingsAccount savingsAccount)
                        {
                            savingsAccount.CalculateInterest();
                        }
                        else if (account is CurrentAccount)
                        {
                            Console.WriteLine("Interest calculation is not applicable for Current Accounts.");
                        }
                        else
                        {
                            Console.WriteLine("Please create an account first!");
                        }
                        break;

                    case 6:
                        // Display Account Information
                        if (account == null)
                        {
                            Console.WriteLine("Please create an account first!");
                        }
                        else
                        {
                            account.PrintAccountInfo();
                        }
                        break;

                    case 7:
                        // Exit
                        Console.WriteLine("Thank you for using the Banking System. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
        }
    }
}
