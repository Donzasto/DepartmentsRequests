using System.Windows;
using DepartmentsRequests.ViewModels.RequestWindow;

namespace DepartmentsRequests.Views
{
    public partial class RequestWindow : Window
    {
        public RequestWindow(RequestViewModel _currentRequestViewModel)
        {
            InitializeComponent();

            DataContext = new RequestWindowViewModel(_currentRequestViewModel);
        }
    }
}
