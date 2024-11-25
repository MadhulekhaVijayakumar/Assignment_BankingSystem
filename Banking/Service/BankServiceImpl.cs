using BankingSystem.Repository;
using BankingSystem.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BankingSystem.Service
{
    public class BankServiceImpl : IBankService
    {
        private readonly IBankRepository _bankRepository;

        public BankServiceImpl(IBankRepository bankRepository)
        {
            _bankRepository = bankRepository;
        }

        public async Task<int> CreateAccountAsync(Customer customer, string accountType, decimal balance)
        {
            return await _bankRepository.CreateAccountAsync(customer, accountType, balance);
        }

        public async Task<Account> GetAccountDetailsAsync(long accountNumber)
        {
            return await _bankRepository.GetAccountDetailsAsync(accountNumber);
        }

        public async Task<decimal> GetAccountBalanceAsync(long accountNumber)
        {
            return await _bankRepository.GetAccountBalanceAsync(accountNumber);
        }

        public async Task<decimal> DepositAsync(long accountNumber, decimal amount)
        {
            return await _bankRepository.DepositAsync(accountNumber, amount);
        }

        public async Task<decimal> WithdrawAsync(long accountNumber, decimal amount)
        {
            return await _bankRepository.WithdrawAsync(accountNumber, amount);
        }

        public async Task<bool> TransferAsync(long fromAccountNumber, long toAccountNumber, decimal amount)
        {
            return await _bankRepository.TransferAsync(fromAccountNumber, toAccountNumber, amount);
        }

        public async Task<List<Transaction>> GetTransactionsAsync(long accountNumber, DateTime fromDate, DateTime toDate)
        {
            return await _bankRepository.GetTransactionsAsync(accountNumber, fromDate, toDate);
        }
    }
}
