namespace ObjectsandClass.Model
{
    internal class Customer
    {
        //Auto implemented getter and setter
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        //Parameterless constructor
        public Customer()
        {
            CustomerId = 0;
            FirstName = "Default";
            LastName = "Customer";
            EmailAddress = "default@example.com";
            PhoneNumber = "000-000-0000";
            Address = "Unknown";
        }

        //Parameterized constructor
        public Customer(int customerId, string firstName, string lastName, string emailAddress, string phoneNumber, string address)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        //Method to print customer information
        public void PrintCustomerInfo()
        {
            Console.WriteLine($"Customer ID: {CustomerId}");
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"Email Address: {EmailAddress}");
            Console.WriteLine($"Phone Number: {PhoneNumber}");
            Console.WriteLine($"Address: {Address}");
        }
    }
}
