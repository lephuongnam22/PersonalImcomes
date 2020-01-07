using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ServiceManagement.DTOs;

namespace ServiceManagement.Services
{
    public interface IExpenseService
    {
        Task AddAsync(ExpenseModel expenseModel);
        Task<IList<ExpenseModel>> GetAllAsync();
        Task DeleteAsync(int id);
        Task<IList<ExpenseModel>> GetExpenseAsync(int month);
    }
}
