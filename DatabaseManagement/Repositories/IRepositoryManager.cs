using System;
using System.Threading.Tasks;

namespace DatabaseManagement.Repositories
{
    public interface IRepositoryManager
    {
        IStockRepository StockRepository { get; }
        IIncomeRepository IncomeRepository { get; }
        ITradingHistoryRepository TradingHistoryRepository { get; }
        IExpenseRepository ExpenseRepository { get; }
        Task<int> SaveChanges();
    }
}
