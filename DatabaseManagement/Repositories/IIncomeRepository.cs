using DatabaseManagement.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManagement.Repositories
{
    public interface IIncomeRepository
    {
        Task AddAsync(Income incomde);
        Task UpdateAsync(Income income);
        Task DeleteAsync(int id);
        Task<IList<Income>> GetIncomesByMonthAsync(int month);
    }
}
