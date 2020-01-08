using DatabaseManagement.Models;
using DatabaseManagement.Repositories;
using ServiceManagement.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceManagement.Services
{
    public class IncomeService : IIncomeService
    {
        private readonly IRepositoryManager _repositoryManager;

        public IncomeService(IRepositoryManager repositoryManager)
        {
            this._repositoryManager = repositoryManager;
        }

        public async Task AddAsync(IncomeModel incomeModel)
        {
            var income = this.MapIncomeModelToIncome(incomeModel);
            await _repositoryManager.IncomeRepository.AddAsync(income);
        }

        public async Task DeleteAsync(int id)
        {
            await _repositoryManager.IncomeRepository.DeleteAsync(id);
        }

        public Task<IList<IncomeModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IList<IncomeModel>> GetIncomesByMonthAsync(int month)
        {
            var incomes = await _repositoryManager.IncomeRepository.GetIncomesByMonthAsync(month);
            return incomes.Select(MapFromIncomeToIncomeModel).ToList();
        }

        private IncomeModel MapFromIncomeToIncomeModel(Income income)
        {
            return new IncomeModel
            {
                Money = income.Money,
                Description = income.Description,
                ReceiveDate = income.ReceivedDate
            };
        }

        private Income MapIncomeModelToIncome(IncomeModel incomeModel)
        {
            return new Income
            {
                Money = incomeModel.Money,
                Description = incomeModel.Description,
                ReceivedDate = incomeModel.ReceiveDate
            };
        }
    }
}
