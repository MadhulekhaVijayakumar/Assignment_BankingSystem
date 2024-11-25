using System;
using System.Text.RegularExpressions;

class Customer
{
    // Attributes
    public string CustomerID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    private string emailAddress;
    private string phoneNumber;
    public string Address { get; set; }

    // Properties with validation
    public string EmailAddress
    {
        get => emailAddress;
        set
        {
            if (IsValidEmail(value))
            {
                emailAddress = value;
            }
            else
            {
                throw new ArgumentException("Invalid email address format.");
            }
        }
    }

    public string PhoneNumber
    {
        get => phoneNumber;
        set
        {
            if (IsValidPhoneNumber(value))
            {
                phoneNumber = value;
            }
            else
            {
                throw new ArgumentException("Invalid phone number format. Must be a 10-digit number.");
            }
        }
    }

    // Default Constructor
    public Customer()
    {
        CustomerID = string.Empty;
        FirstName = string.Empty;
        LastName = string.Empty;
        EmailAddress = string.Empty;
        PhoneNumber = string.Empty;
        Address = string.Empty;
    }

    // Overloaded Constructor
    public Customer(string customerID, string firstName, string lastName, string emailAddress, string phoneNumber, string address)
    {
        CustomerID = customerID;
        FirstName = firstName;
        LastName = lastName;
        EmailAddress = emailAddress;
        PhoneNumber = phoneNumber;
        Address = address;
    }

    // Methods
    public void PrintInfo()
    {
        Console.WriteLine($"Customer ID: {CustomerID}");
        Console.WriteLine($"Name: {FirstName} {LastName}");
        Console.WriteLine($"Email: {EmailAddress}");
        Console.WriteLine($"Phone: {PhoneNumber}");
        Console.WriteLine($"Address: {Address}");
    }

    private bool IsValidEmail(string email)
    {
        return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
    }

    private bool IsValidPhoneNumber(string phone)
    {
        return Regex.IsMatch(phone, @"^\d{10}$");
    }
}
