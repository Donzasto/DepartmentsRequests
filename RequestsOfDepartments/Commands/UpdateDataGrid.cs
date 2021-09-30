using System;
using System.Windows.Input;
using DepartmentsRequests.DAL;
using DepartmentsRequests.ViewModels;

namespace DepartmentsRequests.Commands
{
    internal class UpdateDataGrid : ICommand
    {
        private readonly MainWindowViewModel _mainWindowViewModel;

        public UpdateDataGrid(MainWindowViewModel mainWindowViewModel)
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
            using DepartmentsRequestsContext db = new();

            if (_mainWindowViewModel.SelectedViewModel is OGMehViewModel oGMehViewModel)
            {
                oGMehViewModel.OGMehRequestsDataGrid = _mainWindowViewModel.IsShowAllRequests ? db.OGMehAllRequestsList : db.OGMehOpenRequestsList;
            }
            else if (_mainWindowViewModel.SelectedViewModel is BPUViewModel bPUViewModel)
            {
                bPUViewModel.BPURequestsDataGrid = _mainWindowViewModel.IsShowAllRequests ? db.BPUAllRequestsList : db.BPUOpenRequestsList;
            }
        }
    }
}
