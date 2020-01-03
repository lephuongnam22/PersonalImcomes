using DatabaseManagement.Models.DomainModels;
using PersonalIncomeStatement.Database;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalIncomeStatement.Repositories
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
        }

        public async Task DeleteAsync(int id)
        {
            var income = await this._databaseContext.Incomes.FindAsync(id);
            _databaseContext.Incomes.Remove(income);
        }

        public Task UpdateAsync(Income income)
        {
            throw new NotImplementedException();
        }
    }
}
