using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DatabaseManagement.Models;

namespace DatabaseManagement.Repositories
{
    public interface IExpenseRepository
    {
        Task<int> AddAsync(Expense expense);
        Task<int> DeleteAsync(int id);
        Task<IList<Expense>> GetAllAsync();
        Task<IList<Expense>> GetExpenseByMonth(int month);
    }
}
