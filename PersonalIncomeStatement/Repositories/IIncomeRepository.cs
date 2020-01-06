using DatabaseManagement.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalIncomeStatement.Repositories
{
    public interface IIncomeRepository
    {
        Task AddAsync(Income incomde);

        Task UpdateAsync(Income income);

        Task DeleteAsync(int id);
    }
}
