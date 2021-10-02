using System;
using System.Windows.Input;
using DepartmentsRequests.DAL;
using DepartmentsRequests.ViewModels;

namespace DepartmentsRequests.Commands
{
    internal class UpdateDataGridCommand : ICommand
    {
        private readonly MainWindowViewModel _mainWindowViewModel;

        public UpdateDataGridCommand(MainWindowViewModel mainWindowViewModel)
        {
            _mainWindowViewModel = mainWindowViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            using DepartmentsRequestsContext departmentsRequestsContext = new();

            if (_mainWindowViewModel.SelectedViewModel is OGMehViewModel oGMehViewModel)
            {
                oGMehViewModel.OGMehRequestsDataGrid = _mainWindowViewModel.IsShowAllRequests ? departmentsRequestsContext.OGMehAllRequestsList : departmentsRequestsContext.OGMehOpenRequestsList;
            }
            else if (_mainWindowViewModel.SelectedViewModel is BPUViewModel bPUViewModel)
            {
                bPUViewModel.BPURequestsDataGrid = _mainWindowViewModel.IsShowAllRequests ? departmentsRequestsContext.BPUAllRequestsList : departmentsRequestsContext.BPUOpenRequestsList;
            }
        }
    }
}
