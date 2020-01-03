using System;
using System.Threading.Tasks;
using PersonalIncomeStatement.Database;

namespace PersonalIncomeStatement.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly DatabaseContext _databaseContext;

        public RepositoryManager(DatabaseContext databaseContext)
        {
            this._databaseContext = databaseContext;
            this.StockRepository = new StockRepository(_databaseContext);
            this.IncomeRepository = new IncomeRepository(_databaseContext);
        }

        public IStockRepository StockRepository { get; }
        public IIncomeRepository IncomeRepository { get; }

        public async Task<int> SaveChanges()
        {
            return await _databaseContext.SaveChangesAsync();
        }
    }
}
