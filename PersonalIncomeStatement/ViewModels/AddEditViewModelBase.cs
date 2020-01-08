using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace PersonalIncomeStatement.ViewModels
{
    public class AddEditViewModelBase : ViewModelBase
    {
        public ICommand SaveCommand
        {
            get;
            internal set;
        }

        protected virtual bool CanExecuteSaveCommand()
        {
            return true;
        }

        protected virtual void CreateSaveCommand()
        {
            SaveCommand = new RelayCommand(SaveExecute, CanExecuteSaveCommand);
        }

        public virtual void SaveExecute()
        {
        }
    }
}
