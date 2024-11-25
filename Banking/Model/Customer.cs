namespace BankingSystem.Model

public class Customer
{
    public string CustomerId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    private string _email;
    private string _phone;
    internal object CustomerID;

    public string Email
    {
        get => _email;
        set
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(value, @"^[\w._%+-]+@[a-zA-Z.-]+\.[a-zA-Z]{2,}$"))
                throw new ArgumentException("Invalid email address.");
            _email = value;
        }
    }

    public string Phone
    {
        get => _phone;
        set
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(value, @"^\d{10}$"))
                throw new ArgumentException("Phone number must be 10 digits.");
            _phone = value;
        }
    }

    public string Address { get; set; }

    public override string ToString()
    {
        return $"Customer ID: {CustomerId}, Name: {FirstName} {LastName}, Email: {Email}, Phone: {Phone}, Address: {Address}";
    }
}
