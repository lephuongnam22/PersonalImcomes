using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseManagement.Models;
using DatabaseManagement.Repositories;
using ServiceManagement.DTOs;

namespace ServiceManagement.Services
{
    public class ExpenseService : IExpenseService
    {
        private readonly IRepositoryManager _repositoryManager;

        public ExpenseService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task AddAsync(ExpenseModel expenseModel)
        {
            var expese = this.MapFromExpenseModelToExpense(expenseModel);
            await _repositoryManager.ExpenseRepository.AddAsync(expese);
        }

        public async Task DeleteAsync(int id)
        {
            await _repositoryManager.ExpenseRepository.DeleteAsync(id);
        }

        public async Task<IList<ExpenseModel>> GetAllAsync()
        {
            var expenses = await _repositoryManager.ExpenseRepository.GetAllAsync();
            return expenses.Select(MapFromExpenseToExpenseModel).ToList();
        }

        public async Task<IList<ExpenseModel>> GetExpenseAsync(int month)
        {
            var expenses = await _repositoryManager.ExpenseRepository.GetExpenseByMonth(month);
            return expenses.Select(MapFromExpenseToExpenseModel).ToList();
        }

        private ExpenseModel MapFromExpenseToExpenseModel(Expense expense)
        {
            return new ExpenseModel
            {
                Description = expense.Description,
                Money = expense.Money,
                ExpenseType = expense.ExpenseType,
                ExpenseDate = expense.ExpenseDate
            };
        }

        private Expense MapFromExpenseModelToExpense(ExpenseModel expenseModel)
        {
            return new Expense
            {
                Description = expenseModel.Description,
                ExpenseDate = expenseModel.ExpenseDate,
                Money = expenseModel.Money,
                ExpenseType = expenseModel.ExpenseType
            };
        }
    }
}
