namespace BankingSystem.Model

public abstract class Account
{
    private static long _lastAccountNumber = 1000;

    public long AccountNumber { get; private set; }
    public string AccountType { get; set; }
    public double Balance { get; set; }
    public Customer Customer { get; set; }

    public Account(string accountType, double balance, Customer customer)
    {
        AccountNumber = ++_lastAccountNumber;
        AccountType = accountType;
        Balance = balance;
        Customer = customer;
    }

    public abstract void Withdraw(double amount);

    public override string ToString()
    {
        return $"Account Number: {AccountNumber}, Type: {AccountType}, Balance: {Balance}, Customer: [{Customer}]";
    }
}
