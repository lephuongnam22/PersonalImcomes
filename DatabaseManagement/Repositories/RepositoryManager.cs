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
        }

        public IStockRepository StockRepository { get; }

        public async Task<int> SaveChanges()
        {
            return await _databaseContext.SaveChangesAsync();
        }
    }
}
