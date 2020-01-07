using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DatabaseManagement.Models;

namespace DatabaseManagement.Repositories
{
    public interface IStockRepository
    {
        Task AddStockRecordAsync(Stock stock);
        Task UpdateStockRecordAsync(Stock stock);
        Task DeleteStockRecordAsync(int id);
        Task<IList<Stock>> GetAllAsync();
    }
}
