using System;
using System.Threading.Tasks;

namespace PersonalIncomeStatement.Repositories
{
    public interface IRepositoryManager
    {
        IStockRepository StockRepository { get; }
        IIncomeRepository IncomeRepository { get; }
        Task<int> SaveChanges();
    }
}
