using DatabaseManagement.Models.DomainModels;
using PersonalIncomeStatement.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalIncomeStatement.Services
{
    public interface IIncomeService
    {
        Task<IList<IncomeModel>> GetAllAsync();

        Task AddIncomeAsync(Income incomeModel);
        Task DeleteIncomeAsync(int id);
    }
}
