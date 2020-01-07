using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DatabaseManagement.Database;
using DatabaseManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseManagement.Repositories
{
    public class TradingHistoryRepository : ITradingHistoryRepository
    {
        private readonly DatabaseContext _databaseContext;

        public TradingHistoryRepository(DatabaseContext databaseContext)
        {
            this._databaseContext = databaseContext;
        }

        public async Task AddAsync(TradingHistory tradeHistory)
        {
            await _databaseContext.TradingHistorys.AddAsync(tradeHistory);
        }

        public async Task DeleteAsync(int id)
        {
            await Task.Run(() =>
            {
                var tradingHistory = _databaseContext.TradingHistorys.Find(id);
                _databaseContext.TradingHistorys.Remove(tradingHistory);
            });
        }

        public async Task<IList<TradingHistory>> GetAllAsync()
        {
            return await _databaseContext.TradingHistorys.ToListAsync();
        }
    }
}
