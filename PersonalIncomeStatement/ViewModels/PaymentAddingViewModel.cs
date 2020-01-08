using PersonalIncomeStatement.Models.Enums;
using ServiceManagement.DTOs;
using ServiceManagement.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalIncomeStatement.ViewModels
{
    public class PaymentAddingViewModel : AddEditViewModelBase
    {
        private string _description;
        private int _money;
        private string _expensiveDate;
        private ExpenseType _selectedType;
        private readonly IExpenseService _expensiveService;

        public string Description 
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
                RaisePropertyChange();
            }
        }

        public int Money
        {
            get
            {
                return this._money;
            }
            set
            {
                this._money = value;
                RaisePropertyChange();
            }
        }
        public string ExpensiveDate 
        {
            get
            {
                return this._expensiveDate;
            }
            set 
            {
                this._expensiveDate = value;
                RaisePropertyChange();
            }
        }

        public ExpenseType SelectedType
        {
            get
            {
                return this._selectedType;
            }
            set 
            {
                this._selectedType = value;
                RaisePropertyChange();
            }
        }

        public PaymentAddingViewModel(IExpenseService expensiveService) : base()
        {
            _expensiveService = expensiveService;
        }

        public override void SaveExecute()
        {
            _expensiveService.AddAsync(new ExpenseModel
            {
                Money = Money,
                Description = Description,
                ExpenseDate = DateTime.Parse(ExpensiveDate),
                ExpenseType = (DatabaseManagement.Enums.ExpenseType)Enum.Parse(typeof(DatabaseManagement.Enums.ExpenseType), SelectedType.ToString())
            }).ConfigureAwait(false);
        }
    }
}
