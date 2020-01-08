using PersonalIncomeStatement.Models.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalIncomeStatement.Services
{
    public class ExpensiveService : IExpensiveService
    {
        public Task AddIncomeAsync(Expense incomeModel)
        {
            throw new NotImplementedException();
        }

        public Task DeleteIncomeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Expense>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
