using DatabaseManagement.Models.DomainModels;
using PersonalIncomeStatement.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PersonalIncomeStatement.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
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

        public MainWindowViewModel(IIncomeService incomeService)
        {
            this._incomeService = incomeService;
            CreateSaveCommand();
        }

        public ICommand SaveCommand
        {
            get;
            internal set;
        }

        private bool CanExecuteSaveCommand()
        {
            return true;
        }

        private void CreateSaveCommand()
        {
            SaveCommand = new RelayCommand(SaveExecute, CanExecuteSaveCommand);
        }

        public void SaveExecute()
        {
            Task task = _incomeService.AddIncomeAsync(new Income
            {
                Money = this.Money,
                Description = this.Description,
                ReceivedDate = DateTime.Parse(this.ReceiveDate)
            });

            task.ConfigureAwait(false);

         
        }
    }
}
