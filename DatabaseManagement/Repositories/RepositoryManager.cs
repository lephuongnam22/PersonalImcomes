using System;
using System.Threading.Tasks;
using DatabaseManagement.Database;

namespace DatabaseManagement.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly DatabaseContext _databaseContext;

        public RepositoryManager(DatabaseContext databaseContext)
        {
            this._databaseContext = databaseContext;
            this.StockRepository = new StockRepository(_databaseContext);
            this.IncomeRepository = new IncomeRepository(_databaseContext);
            this.TradingHistoryRepository = new TradingHistoryRepository(_databaseContext);
            this.ExpenseRepository = new ExpenseRepository(_databaseContext);
        }

        public IStockRepository StockRepository { get; }
        public IIncomeRepository IncomeRepository { get; }
        public ITradingHistoryRepository TradingHistoryRepository { get; }
        public IExpenseRepository ExpenseRepository { get; }

        public async Task<int> SaveChanges()
        {
            return await _databaseContext.SaveChangesAsync();
        }
    }
}
