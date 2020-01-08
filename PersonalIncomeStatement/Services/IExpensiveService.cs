using PersonalIncomeStatement.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalIncomeStatement.Services
{
    public interface IExpensiveService
    {
        Task<IList<Expense>> GetAllAsync();

        Task AddIncomeAsync(Expense incomeModel);
        Task DeleteIncomeAsync(int id);
    }
}
