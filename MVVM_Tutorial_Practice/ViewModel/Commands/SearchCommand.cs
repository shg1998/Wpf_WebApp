using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MVVM_Tutorial_Practice.ViewModel.Commands
{
    public class SearchCommand : ICommand
    {
        public WheatherViewModel vm { get; set; }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

       

        public SearchCommand(WheatherViewModel wheatherViewModel)
        {
            this.vm = wheatherViewModel;
        }

        public bool CanExecute(object parameter)
        {
            string query = parameter as string;
            if (string.IsNullOrWhiteSpace(query))
            {
                return false;
            }
            return true;
        }

        public void Execute(object parameter)
        {
            vm.makeQuery();
        }
    }
}
