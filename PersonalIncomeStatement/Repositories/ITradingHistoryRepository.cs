using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DatabaseManagement.Models.DomainModels;

namespace DatabaseManagement.Repositories
{
    public interface ITradingHistoryRepository
    {
        Task AddAsync(TradingHistory tradingHistory);
        Task DeleteAsync(int id);
        Task<IList<TradingHistory>> GetAllAsync();
    }
}
