namespace BankingSystem.Service
{
    public interface IBankService
    {
        Task<int> CreateAccountAsync(Customer customer, string accountType, decimal balance);
        Task<Account> GetAccountDetailsAsync(long accountNumber);
        Task<decimal> GetAccountBalanceAsync(long accountNumber);
        Task<decimal> DepositAsync(long accountNumber, decimal amount);
        Task<decimal> WithdrawAsync(long accountNumber, decimal amount);
        Task<bool> TransferAsync(long fromAccountNumber, long toAccountNumber, decimal amount);
        Task<List<Transaction>> GetTransactionsAsync(long accountNumber, DateTime fromDate, DateTime toDate);
    }
}
