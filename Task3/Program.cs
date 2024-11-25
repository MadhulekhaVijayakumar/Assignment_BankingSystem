using System.Diagnostics.Metrics;
using System.Threading.Tasks;
using System;
using System.ComponentModel;
using System.Security.Principal;
using System.Transactions;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Task 1: Conditional Statement
            //1. Write a program that takes the customer's credit score and annual income as input.
            //Console.WriteLine("Enter Your Credit Score:");
            //int creditScore = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Your Annual income:");
            //int annualIncome = Convert.ToInt32(Console.ReadLine());

            ////2.Use conditional statements(if-else) to determine if the customer is eligible for a loan.
            ////3.Display an appropriate message based on eligibility.
            //if (creditScore > 700 && annualIncome >= 50000)
            //{
            //    Console.WriteLine("The Customer is eligible for loan.");
            //}
            //else
            //{
            //    Console.WriteLine("The Customer is not eligible for a loan.");
            //}
            #endregion
            #region Task2
            //Console.WriteLine("Enter your current balance:");
            //double currentBalance = Convert.ToDouble(Console.ReadLine());
            //if (currentBalance < 0)
            //{
            //    Console.WriteLine("Invalid Balance!!\nPlease enter a valid balance: ");
            //}
            //int choice = 0;
            //bool value = true;
            //while (value)
            //{

            //    Console.WriteLine("\nATM Menu");
            //    Console.WriteLine("1.Chech Balance");
            //    Console.WriteLine("2.Withdraw");
            //    Console.WriteLine("3.Deposit");
            //    Console.WriteLine("4.Exit");
            //    Console.WriteLine("Enter Your Choice:");
            //    choice = Convert.ToInt32(Console.ReadLine());
            //    switch (choice)
            //    {
            //        case 1:
            //            Console.WriteLine($"Your current balance is:{currentBalance}");
            //            break;
            //        case 2:
            //            Console.WriteLine("Enter the amount to withdraw (in multiples of 100 and 500):");
            //            double withdrawAmount = Convert.ToDouble(Console.ReadLine());
            //            if (withdrawAmount > currentBalance)
            //            {
            //                Console.WriteLine("Insufficient balance");
            //            }
            //            else if (withdrawAmount % 100 != 0 && withdrawAmount % 500 != 0)
            //            {
            //                Console.WriteLine("Withdrawal amount must be in multiples of 100 or 500.");
            //            }
            //            else
            //            {
            //                currentBalance -= withdrawAmount;
            //                Console.WriteLine($"Withdrawal Successful!!\nYour new balance is: {currentBalance}");
            //            }
            //            break;
            //        case 3:
            //            Console.WriteLine("Enter the amount to deposit");
            //            double depositAmount = Convert.ToDouble(Console.ReadLine());
            //            if (depositAmount <= 0)
            //            {
            //                Console.WriteLine("Invaild deposit amount");
            //            }
            //            else
            //            {
            //                currentBalance += depositAmount;
            //                Console.WriteLine($"Deposit Successful!!\nYour new balance: {currentBalance}");

            //            }
            //            break;
            //        case 4:
            //            value = false;
            //            Console.WriteLine("Thank you for using ATM.\nGoodBye!!");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid choice");
            //            break;
            //    }

            //}
            #endregion
            #region Task3
            ////Task 3: Loop Structures
            //Console.WriteLine("Enter the number of customers:");
            //int customerCount=Convert.ToInt32(Console.ReadLine());
            //double [] initialBalances = new double[customerCount];
            //double [] futureBalances = new double[customerCount];
            //double annualInterest = 0.0;
            //int years = 0;
            //for (int i = 0; i < customerCount; i++)
            //{
            //    Console.WriteLine($"Customer {i + 1}:");
            //    Console.WriteLine("Enter the initial balance: ");
            //    initialBalances[i] = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("Enter the annual interest rate(as a percentage): ");
            //    annualInterest = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("Enter the number of years: ");
            //    years = Convert.ToInt32(Console.ReadLine());
            //    futureBalances[i] = initialBalances[i] * Math.Pow((1 + annualInterest / 100), years);
            //}
            //Console.WriteLine("Future Balances:");
            //for(int i = 0;i < customerCount; i++)
            //{
            //    Console.WriteLine($"Customer {i + 1}\nFuture Balance: {futureBalances[i]:C2}");
            //}
            #endregion
            #region Task4
            //Task 4: Looping, Array and Data Validation
            //1.Create a C# program that simulates a bank with multiple customer accounts.
            //int[] accountNumber = new int[] { 1001, 1002, 1003, 1004, 1005 };
            //double[] balances = new double[] { 2500, 3400, 1200, 850, 1500 };
            //Console.WriteLine("Welcome to bank balance checker!");
            ////2.Use a loop(e.g., while loop) to repeatedly ask the user for their account number and balance until they enter a valid account number.
            //while (true)
            //{
            //    Console.WriteLine("Please enter your account number:");
            //    int acc = Convert.ToInt32(Console.ReadLine());
            //    int index = Array.IndexOf(accountNumber, acc);
            //    //3.Validate the account number entered by the user.
            //    //4.If the account number is valid, display the account balance.If not, ask the user to try again.
            //    if (index != -1)
            //    {
            //        Console.WriteLine($"Your account balance: Rs.{balances[index]}");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid account number. Please try again!!");
            //    }
            //}
            //Console.WriteLine("Thank you for using the bank balance checker");
            #endregion
            #region Task5
            //Task 5: Password Validation
            //Write a program that prompts the user to create a password for their bank account.
            //while (true)
            //{
            //    Console.WriteLine("Create a password for your bank account");
            //    Console.WriteLine("Enter a password:");
            //    string password = Console.ReadLine();
            //    if (password.Length < 8)
            //    {
            //        Console.WriteLine("Invalid Password!!\nIt must contain atleast 8 characters.");
            //    }
            //    else if (!password.Any(char.IsUpper))
            //    {
            //        Console.WriteLine("Invalid Password!!\nIt must contain atleast one uppercase letter.");
            //    }
            //    else if (!password.Any(char.IsDigit))
            //    {
            //        Console.WriteLine("Invalid Password!!\nIt must contain atleast one digit.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Password is valid!!");
            //        break;
            //    }
            //}
            #endregion
            #region Task6
            //Task6
            //Create a program that maintains a list of bank transactions (deposits and withdrawals) for a customer.
            //Use a while loop to allow the user to keep adding transactions until they choose to exit.
            //Display the transaction history upon exit using looping statements.
            //List<string> transactions = new List<string>();
            //bool value = true;
            //double total=0;
            //Console.WriteLine("Welcome to the Bank Transaction System!");
            //while (value)
            //{
            //    Console.WriteLine("\nMenu");
            //    Console.WriteLine("1. Deposit");
            //    Console.WriteLine("2. Withdrawal");
            //    Console.WriteLine("3. Exit and View transaction history");
            //    Console.WriteLine("Enter a choice");
            //    int choice = Convert.ToInt32(Console.ReadLine());
            //    switch (choice)
            //    {
            //        case 1:
            //            Console.WriteLine("Enter deposit amount: ");
            //            double deposit = Convert.ToDouble(Console.ReadLine());
            //            if (deposit > 0)
            //            {
            //                transactions.Add($"Deposit    : {deposit}");
            //                Console.WriteLine("Deposit Recorded.");
            //                total += deposit;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Deposit amount must be positive.");
            //            }
            //            break;
            //        case 2:
            //            Console.WriteLine("Enter Withdrawal amount: ");
            //            double withdrawal = Convert.ToDouble(Console.ReadLine());
            //            if (withdrawal > 0)
            //            {
            //                transactions.Add($"Withdrawal : {withdrawal}");
            //                Console.WriteLine("Withdrawal recorded.");
            //                total -= withdrawal;
            //            }
            //            else
            //            {
            //                Console.WriteLine("Withdrawal amount must be positive.");
            //            }
            //            break;
            //        case 3:
            //            value = false;
            //            break;
            //        default:
            //            Console.WriteLine("Invalid option.Please choose correct option!!");
            //            break;

            //    }

            //}

            //Console.WriteLine("\nTransaction Record\n");
            //foreach (string transaction in transactions)
            //{
            //    Console.WriteLine(transaction);
            //}
            //Console.WriteLine($"\nAvailable Balance: {total}");
            //Console.WriteLine("\n\nThank you!!!");
            #endregion

        }
    }
}
