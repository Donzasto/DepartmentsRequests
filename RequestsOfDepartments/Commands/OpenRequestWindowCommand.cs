using DepartmentsRequests.Views;
using System;
using System.Windows.Input;

namespace DepartmentsRequests.Commands
{
    internal class OpenRequestWindowCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            new RequestWindow().ShowDialog();
        }
    }
}
