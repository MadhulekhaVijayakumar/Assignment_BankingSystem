using ObjectsandClass.Model;
namespace ObjectandClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 7
            #region Customer
            //Customer default constructor 
            //Console.WriteLine("Displaying default values:");
            //Customer defaultCustomer = new Customer();
            //defaultCustomer.PrintCustomerInfo();

            ////parameterized constructor
            //Console.WriteLine("\nDisplaying values using parameterized constructor:");
            //Customer newCustomer = new Customer(101, "John", "Doe", "john.doe@example.com", "123-456-7890", "123 Main St, Anytown, USA");
            //newCustomer.PrintCustomerInfo();

            ////Updating properties
            //newCustomer.FirstName = "Jane";
            //newCustomer.LastName = "Smith";

            //Console.WriteLine("\nUpdated Customer Information:");
            //newCustomer.PrintCustomerInfo();
            #endregion
            #region Account
            // Default Account
            //Console.WriteLine("Default Account:");
            //Account defaultAccount = new Account();
            //defaultAccount.PrintAccountInfo();

            //// Parameterized Account
            //Console.WriteLine("New Account:");
            //Account newAccount = new Account(12345, "Savings", 10000.0f);
            //newAccount.PrintAccountInfo();

            //// Perform Deposit
            //Console.WriteLine("Depositing 5000...");
            //newAccount.Deposit(5000);

            //// Perform Withdrawal
            //Console.WriteLine("Withdrawing 3000...");
            //newAccount.Withdraw(3000);

            //// Calculate Interest
            //Console.WriteLine("Calculating interest...");
            //newAccount.CalculateInterest();

            //// Updated Account Information
            //Console.WriteLine("Updated Account Information:");
            //newAccount.PrintAccountInfo();
            #endregion
            //Task 8
            #region 1.Modify Account
            //Account account = new Account(12345, "Savings", 10000.0f);
            //account.PrintAccountInfo();

            //// Deposit Overloads
            //Console.WriteLine("Depositing using float...");
            //account.Deposit(1500.5f);

            //Console.WriteLine("Depositing using int...");
            //account.Deposit(2000);

            //Console.WriteLine("Depositing using double...");
            //account.Deposit(3000.75);

            //// Withdraw Overloads
            //Console.WriteLine("Withdrawing using float...");
            //account.Withdraw(500.5f);

            //Console.WriteLine("Withdrawing using int...");
            //account.Withdraw(4000);

            //Console.WriteLine("Withdrawing using double...");
            //account.Withdraw(2000.25);

            //// Attempt Insufficient Withdrawal
            //Console.WriteLine("Attempting to withdraw more than available balance...");
            //account.Withdraw(30000);

            //// Final Account Info
            //account.PrintAccountInfo();
            #endregion
            #region 2.Subclasses
            //Console.WriteLine("Savings Account:");
            //SavingsAccount savings = new SavingsAccount(12345, "Savings", 10000.0f, 4.5f);
            //savings.PrintAccountInfo();
            //savings.CalculateInterest();
            //savings.Deposit(2000);
            //savings.Withdraw(5000);

            //Console.WriteLine();

            //// Create a Current Account
            //Console.WriteLine("Current Account:");
            //CurrentAccount current = new CurrentAccount(54321, "Current", 2000.0f);
            //current.PrintAccountInfo();
            //current.Deposit(1000);
            //current.Withdraw(2500);
            //Console.WriteLine("Attempting to withdraw beyond overdraft limit...");
            //current.Withdraw(10000);

            //// Final Account Information
            //Console.WriteLine("\nFinal Savings Account Info:");
            //savings.PrintAccountInfo();

            //Console.WriteLine("\nFinal Current Account Info:");
            //current.PrintAccountInfo();
            #endregion
            #region 3.Bank class
            //Bank bank = new Bank();
            //bank.StartBanking();
            #endregion
            

        }
    }
}
