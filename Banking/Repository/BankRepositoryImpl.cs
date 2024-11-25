using BankingSystem.Model;
using Microsoft.Data.SqlClient;
using ProjectManagementSystem.Utility;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BankingSystem.Repository
{
    public class BankRepositoryImpl : IBankRepository
    {
        public async Task<int> CreateAccountAsync(Customer customer, string accountType, decimal balance)
        {
            using (var conn = DBConnUtil.GetConnection())
            {
                await conn.OpenAsync();
                var query = "INSERT INTO Accounts (AccountType, AccountBalance, CustomerID) OUTPUT INSERTED.AccountNumber VALUES (@AccountType, @Balance, @CustomerID)";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AccountType", accountType);
                    cmd.Parameters.AddWithValue("@Balance", balance);
                    cmd.Parameters.AddWithValue("@CustomerID", customer.CustomerID);

                    var accountNumber = await cmd.ExecuteScalarAsync();
                    return Convert.ToInt32(accountNumber);
                }
            }
        }

        public async Task<Account> GetAccountDetailsAsync(long accountNumber)
        {
            using (var conn = DBConnUtil.GetConnection())
            {
                await conn.OpenAsync();
                var query = "SELECT * FROM Accounts WHERE AccountNumber = @AccountNumber";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AccountNumber", accountNumber);
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            var account = new Account
                            {
                                AccountNumber = reader.GetInt64(0),
                                AccountType = reader.GetString(1),
                                AccountBalance = reader.GetDecimal(2),
                                CustomerID = reader.GetInt32(3)
                            };
                            return account;
                        }
                    }
                }
            }
            return null;
        }

        public async Task<decimal> GetAccountBalanceAsync(long accountNumber)
        {
            using (var conn = DBConnUtil.GetConnection())
            {
                await conn.OpenAsync();
                var query = "SELECT AccountBalance FROM Accounts WHERE AccountNumber = @AccountNumber";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AccountNumber", accountNumber);
                    var balance = await cmd.ExecuteScalarAsync();
                    return Convert.ToDecimal(balance);
                }
            }
        }

        public async Task<decimal> DepositAsync(long accountNumber, decimal amount)
        {
            using (var conn = DBConnUtil.GetConnection())
            {
                await conn.OpenAsync();
                var query = "UPDATE Accounts SET AccountBalance = AccountBalance + @Amount WHERE AccountNumber = @AccountNumber";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@AccountNumber", accountNumber);
                    await cmd.ExecuteNonQueryAsync();
                }
            }

            return await GetAccountBalanceAsync(accountNumber);
        }

        public async Task<decimal> WithdrawAsync(long accountNumber, decimal amount)
        {
            using (var conn = DBConnUtil.GetConnection())
            {
                await conn.OpenAsync();
                var query = "UPDATE Accounts SET AccountBalance = AccountBalance - @Amount WHERE AccountNumber = @AccountNumber";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    cmd.Parameters.AddWithValue("@AccountNumber", accountNumber);
                    await cmd.ExecuteNonQueryAsync();
                }
            }

            return await GetAccountBalanceAsync(accountNumber);
        }

        public async Task<bool> TransferAsync(long fromAccountNumber, long toAccountNumber, decimal amount)
        {
            var fromAccountBalance = await GetAccountBalanceAsync(fromAccountNumber);
            if (fromAccountBalance < amount)
                return false;

            await WithdrawAsync(fromAccountNumber, amount);
            await DepositAsync(toAccountNumber, amount);

            return true;
        }

        public async Task<List<Transaction>> GetTransactionsAsync(long accountNumber, DateTime fromDate, DateTime toDate)
        {
            var transactions = new List<Transaction>();
            using (var conn = DBConnUtil.GetConnection())
            {
                await conn.OpenAsync();
                var query = "SELECT * FROM Transactions WHERE AccountNumber = @AccountNumber AND TransactionDate BETWEEN @FromDate AND @ToDate";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AccountNumber", accountNumber);
                    cmd.Parameters.AddWithValue("@FromDate", fromDate);
                    cmd.Parameters.AddWithValue("@ToDate", toDate);
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            transactions.Add(new Transaction
                            {
                                AccountNumber = reader.GetInt64(0),
                                Description = reader.GetString(1),
                                TransactionType = reader.GetString(2),
                                TransactionAmount = reader.GetDecimal(3),
                                TransactionDate = reader.GetDateTime(4)
                            });
                        }
                    }
                }
            }
            return transactions;
        }

        public Task<int> CreateAccountAsync(Customer customer, string accountType, decimal balance)
        {
            throw new NotImplementedException();
        }

        Task<Account> IBankRepository.GetAccountDetailsAsync(long accountNumber)
        {
            throw new NotImplementedException();
        }

        Task<List<Transaction>> IBankRepository.GetTransactionsAsync(long accountNumber, DateTime fromDate, DateTime toDate)
        {
            throw new NotImplementedException();
        }
    }
}
