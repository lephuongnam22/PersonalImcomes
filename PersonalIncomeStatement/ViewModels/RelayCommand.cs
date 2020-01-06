using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace PersonalIncomeStatement.ViewModels
{
    public class RelayCommand : ICommand
    {
        Action _execteMethod;
        Func<bool> _canexecuteMethod;

        public RelayCommand(Action execteMethod, Func<bool> canexecuteMethod)
        {
            _execteMethod = execteMethod;
            _canexecuteMethod = canexecuteMethod;
        }  
        public bool CanExecute()
        {
            if (_canexecuteMethod != null)
            {
                return _canexecuteMethod();
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Wires CanExecuteChanged event 
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public void Execute()
        {
            _execteMethod();
        }

        public bool CanExecute(object parameter)
        {
            if (_canexecuteMethod != null)
            {
                return _canexecuteMethod();
            }
            else
            {
                return false;
            }
        }

        public void Execute(object parameter)
        {
            _execteMethod();
        }
    }
}
