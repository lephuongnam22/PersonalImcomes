using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DatabaseManagement.Database;
using DatabaseManagement.Models.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace DatabaseManagement.Repositories
{
    public class StockRepository : IStockRepository
    {
        private readonly DatabaseContext _databaseContext;

        public StockRepository(DatabaseContext databaseContext)
        {
            this._databaseContext = databaseContext;
        }

        public async Task AddStockRecordAsync(Stock stock)
        {
            await _databaseContext.Stocks.AddAsync(stock);
        }

        public async Task DeleteStockRecordAsync(int id)
        {
            await Task.Run(() =>
            {
                var stock = _databaseContext.Stocks.Find(id);

                if (stock != null)
                {
                    _databaseContext.Stocks.Remove(stock);
                }
            });
        }

        public async Task<IList<Stock>> GetAllAsync()
        {
            return await this._databaseContext.Stocks.ToListAsync();
        }

        public Task UpdateStockRecordAsync(Stock stock)
        {
            throw new NotImplementedException();
        }
    }
}
