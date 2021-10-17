using System;
using System.Windows.Input;
using DepartmentsRequests.ViewModels.MainWindow;
using DepartmentsRequests.Views;

namespace DepartmentsRequests.Commands
{
    internal class OpenRequestWindowCommand : ICommand
    {
        private MainWindowViewModel _currentRequestViewModel;

        public OpenRequestWindowCommand(MainWindowViewModel currentRequestViewModel)
        {
            _currentRequestViewModel = currentRequestViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            new RequestWindow(_currentRequestViewModel.SelectedViewModel.CurrentRequestViewModel).ShowDialog();
        }
    }
}
