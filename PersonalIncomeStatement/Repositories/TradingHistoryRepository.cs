using System;
using PersonalIncomeStatement.Database;
using PersonalIncomeStatement.Models.DomainModels;

namespace PersonalIncomeStatement.Repositories
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

        public async Task<IList<TradingHistory>> GetAllAsync()
        {
            await _databaseContext.TradingHistorys.ToListAsync();
        }
    }
}
