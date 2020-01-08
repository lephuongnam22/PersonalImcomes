using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseManagement.Database;
using DatabaseManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseManagement.Repositories
{
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly DatabaseContext _databaseContext;

        public ExpenseRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<int> AddAsync(Expense expense)
        {
            await _databaseContext.AddAsync(expense);
            return await _databaseContext.SaveChangesAsync();
        }

        public async Task<int> DeleteAsync(int id)
        {
            var expense = _databaseContext.Expenses.Find(id);

            if (expense != null)
            {
                _databaseContext.Expenses.Remove(expense);
                return await _databaseContext.SaveChangesAsync();
            }

            return -1;
        }

        public Task<IList<Expense>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Expense>> GetExpenseByMonth(int month)
        {
            var startOfTthisMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            var firstDay = startOfTthisMonth.AddMonths(-1);
            var lastDay = startOfTthisMonth.AddDays(-1);
            return await this._databaseContext.Expenses.Where(n => n.ExpenseDate >= firstDay
            && n.ExpenseDate <= lastDay).OrderBy(n => n.ExpenseDate).ToListAsync();
        }
    }
}
