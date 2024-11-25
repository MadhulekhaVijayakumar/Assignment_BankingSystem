namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your current balance:");
            double currentBalance = Convert.ToDouble(Console.ReadLine());
            if (currentBalance < 0)
            {
                Console.WriteLine("Invalid Balance!!\nPlease enter a valid balance: ");
            }
            int choice = 0;
            bool value = true;
            while (value)
            {

                Console.WriteLine("\nATM Menu");
                Console.WriteLine("1.Chech Balance");
                Console.WriteLine("2.Withdraw");
                Console.WriteLine("3.Deposit");
                Console.WriteLine("4.Exit");
                Console.WriteLine("Enter Your Choice:");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Your current balance is:{currentBalance}");
                        break;
                    case 2:
                        Console.WriteLine("Enter the amount to withdraw (in multiples of 100 and 500):");
                        double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                        if (withdrawAmount > currentBalance)
                        {
                            Console.WriteLine("Insufficient balance");
                        }
                        else if (withdrawAmount % 100 != 0 && withdrawAmount % 500 != 0)
                        {
                            Console.WriteLine("Withdrawal amount must be in multiples of 100 or 500.");
                        }
                        else
                        {
                            currentBalance -= withdrawAmount;
                            Console.WriteLine($"Withdrawal Successful!!\nYour new balance is: {currentBalance}");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter the amount to deposit");
                        double depositAmount = Convert.ToDouble(Console.ReadLine());
                        if (depositAmount <= 0)
                        {
                            Console.WriteLine("Invaild deposit amount");
                        }
                        else
                        {
                            currentBalance += depositAmount;
                            Console.WriteLine($"Deposit Successful!!\nYour new balance: {currentBalance}");

                        }
                        break;
                    case 4:
                        value = false;
                        Console.WriteLine("Thank you for using ATM.\nGoodBye!!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            }
        }
    }
    
}
