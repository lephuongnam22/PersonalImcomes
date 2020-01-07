using DatabaseManagement.Models;
using ServiceManagement.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceManagement.Services
{
    public interface IIncomeService
    {
        Task<IList<IncomeModel>> GetAllAsync();
        Task AddAsync(IncomeModel incomeModel);
        Task DeleteAsync(int id);
        Task<IList<IncomeModel>> GetIncomesByMonthAsync(int month);
    }
}
