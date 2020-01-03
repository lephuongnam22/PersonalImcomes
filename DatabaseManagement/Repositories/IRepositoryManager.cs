using System;
using System.Threading.Tasks;

namespace DatabaseManagement.Repositories
{
    public interface IRepositoryManager
    {
        IStockRepository StockRepository { get; }
        Task<int> SaveChanges();
    }
}
