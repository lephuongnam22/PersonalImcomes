using PersonalIncomeStatement.Models.Enums;
using ServiceManagement.DTOs;
using ServiceManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonalIncomeStatement.ViewModels
{
    public class ExpenseDetailViewModel : ViewModelBase
    {
        private readonly IExpenseService _expenseService;
        private IList<ExpenseDetailModel> _expenseDetailModels;
        private int _selectedMonth;
        private IList<int> _months;

        public IList<int> Months
        {
            get
            {
                return this._months;
            }
        }

        public int SelectedMonth
        {
            get
            {
                return this._selectedMonth;
            }
            set
            {
                
                if (_selectedMonth != value)
                {
                    this._selectedMonth = value;
                    RaisePropertyChange();
                    this.GetExpenseByMonth();
                }
            }
        }

        public IList<ExpenseDetailModel> ExpenseDetailModels
        {
            get
            {
                return this._expenseDetailModels;
            }
            set
            {
                
                this._expenseDetailModels = value;
                RaisePropertyChange();
            }
        }

        public ExpenseDetailViewModel(IExpenseService expenseService)
        {
            _expenseService = expenseService;
            this._months = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            this.SelectedMonth = 1;
        }

        private async void GetExpenseByMonth()
        {
            var result = await _expenseService.GetExpenseAsync(SelectedMonth).ConfigureAwait(false);
            this.ExpenseDetailModels = result.Select(MapFromExpenseModelToExpenseDetailModel).ToList();
        }

        private ExpenseDetailModel MapFromExpenseModelToExpenseDetailModel(ExpenseModel expenseModel)
        {
            return new ExpenseDetailModel
            {
                ExpenseType = (ExpenseType)Enum.Parse(typeof(ExpenseType), expenseModel.ExpenseType.ToString()),
                Money = expenseModel.Money.ToString(),
                Description = expenseModel.Description,
                Date = expenseModel.ExpenseDate.ToString("yyyyMMdd")
            };
        }
    }
}
