using DatabaseManagement.Models.DomainModels;
using PersonalIncomeStatement.Models.DTOs;
using PersonalIncomeStatement.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalIncomeStatement.Services
{
    public class IncomeService : IIncomeService
    {
        private readonly IRepositoryManager _repositoryManager;
        public IncomeService(IRepositoryManager repositoryManager)
        {
            this._repositoryManager = repositoryManager;
        }

        public async Task AddIncomeAsync(Income income)
        {
            await _repositoryManager.IncomeRepository.AddAsync(income);
            await _repositoryManager.SaveChanges();
        }

        public Task DeleteIncomeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<IncomeModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        private Income MapIncomeModelToIncome(IncomeModel incomeModel)
        {
            return new Income();
        }
    }
}
