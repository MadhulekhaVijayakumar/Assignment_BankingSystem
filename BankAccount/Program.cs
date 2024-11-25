using System;
//Task9
class Program
{
    static void Main(string[] args)
    {
        Bank bank = new Bank();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n=== Banking System Menu ===");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit Amount");
            Console.WriteLine("3. Withdraw Amount");
            Console.WriteLine("4. Calculate Interest");
            Console.WriteLine("5. Display Account Info");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    bank.CreateAccount();
                    break;
                case 2:
                    bank.Deposit();
                    break;
                case 3:
                    bank.Withdraw();
                    break;
                case 4:
                    bank.CalculateInterest();
                    break;
                case 5:
                    bank.PrintAccountInfo();
                    break;
                case 6:
                    Console.WriteLine("Exiting the system. Thank you!");
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
