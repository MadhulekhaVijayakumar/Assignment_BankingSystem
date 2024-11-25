namespace BankingSystem.Exceptions
{
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message) { }
    }

    public class InvalidAccountException : Exception
    {
        public InvalidAccountException(string message) : base(message) { }
    }

    public class OverdraftLimitExceededException : Exception
    {
        public OverdraftLimitExceededException(string message) : base(message) { }
    }
}
