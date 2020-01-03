using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PersonalIncomeStatement.Models.DomainModels;

namespace PersonalIncomeStatement.Repositories
{
    public interface IStockRepository
    {
        Task AddStockRecordAsync(Stock stock);
        Task UpdateStockRecordAsync(Stock stock);
        Task DeleteStockRecordAsync(int id);
        Task<IList<Stock>> GetAllAsync();
    }
}
