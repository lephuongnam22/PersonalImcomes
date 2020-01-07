using DatabaseManagement.Models;
using DatabaseManagement.Database;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DatabaseManagement.Repositories
{
    public class IncomeRepository : IIncomeRepository
    {
        private readonly DatabaseContext _databaseContext;

        public IncomeRepository(DatabaseContext databaseContext)
        {
            this._databaseContext = databaseContext;
        }

        public async Task AddAsync(Income incomde)
        {
            await this._databaseContext.Incomes.AddAsync(incomde);
            await _databaseContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var income = await this._databaseContext.Incomes.FindAsync(id);

            if (income != null)
            {
                _databaseContext.Incomes.Remove(income);
                await _databaseContext.SaveChangesAsync();
            }
        }

        public async Task<IList<Income>> GetIncomesByMonthAsync(int month)
        {
            var startOfTthisMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            var firstDay = startOfTthisMonth.AddMonths(-1);
            var lastDay = startOfTthisMonth.AddDays(-1);
            return await this._databaseContext.Incomes.Where(n => n.ReceivedDate >= firstDay
            && n.ReceivedDate <= lastDay).OrderBy(n => n.ReceivedDate).ToListAsync();
        }

        public Task UpdateAsync(Income income)
        {
            throw new NotImplementedException();
        }
    }
}
