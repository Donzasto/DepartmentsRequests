using DepartmentsRequests.DAL;
using DepartmentsRequests.ViewModels;
using System;
using System.Windows.Input;

namespace DepartmentsRequests.Commands
{
    internal class UpdateDataGrid : ICommand
    {
        private MainWindowViewModel _mainWindowViewModel;

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

            if (_mainWindowViewModel.IsShowAllRequests)
            {
                ((OGMehViewModel)_mainWindowViewModel.ViewModelsList[0]).OGMehRequestsDataGrid = db.OGMehOpenRequestsList;
            //    ((OGMehViewModel)_mainWindowViewModel.SelectedViewModel).OGMehRequestsDataGrid = db.OGMehOpenRequestsList;
            }
            else
            {
                ((OGMehViewModel)_mainWindowViewModel.ViewModelsList[0]).OGMehRequestsDataGrid = db.OGMehRequestsList;
            }
        }
    }
}
