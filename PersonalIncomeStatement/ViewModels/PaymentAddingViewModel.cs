using PersonalIncomeStatement.Models.Enums;
using PersonalIncomeStatement.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalIncomeStatement.ViewModels
{
    public class PaymentAddingViewModel : ViewModelBase
    {
        private string _description;
        private int _money;
        private string _expensiveDate;
        private ExpenseType _selectedType;

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

        public PaymentAddingViewModel(IExpensiveService expensiveService)
        {
            
        }
    }
}
