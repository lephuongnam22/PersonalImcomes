using ServiceManagement.DTOs;
using ServiceManagement.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PersonalIncomeStatement.ViewModels
{
    public class IncomeAddingViewModel : AddEditViewModelBase
    {
        private decimal money;
        private string description;
        private string receiveDate;

        private readonly IIncomeService _incomeService;

        public string ReceiveDate
        {
            get
            {
                return this.receiveDate;
            }
            set
            {
                this.receiveDate = value;
                this.RaisePropertyChange();
            }
        }
        public decimal Money
        {
            get
            {
                return this.money;
            }
            set
            {
                this.money = value;
                this.RaisePropertyChange();
            }
        }
        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
                this.RaisePropertyChange();
            }
        }

        public IncomeAddingViewModel(IIncomeService incomeService) : base()
        {
            this._incomeService = incomeService;
        }

        public override void SaveExecute()
        {
            Task task = _incomeService.AddAsync(new IncomeModel
            {
                Money = this.Money,
                Description = this.Description,
                ReceiveDate = DateTime.Parse(this.ReceiveDate)
            });

            task.ConfigureAwait(false);
        }
    }
}
