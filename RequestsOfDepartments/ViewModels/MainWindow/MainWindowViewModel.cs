using System.Collections.Generic;
using System.Windows.Input;
using DepartmentsRequests.Commands;
using DepartmentsRequests.ViewModels.RequestWindow;

namespace DepartmentsRequests.ViewModels.MainWindow
{
    public class MainWindowViewModel : BaseViewModel
    {
        private DepartmentViewModel _selectedViewModel;

        public MainWindowViewModel()
        {
            ViewModelsList = new List<DepartmentViewModel>()
            {
                new OGMehViewModel(){ ShortName = "ОГМех", Title = "Заявки на ремонт оборудования", CurrentRequestViewModel = new OGMehRequestViewModel() },
                new BPUViewModel(){ ShortName = "БПУ", Title =  "Заявки на управлющие программы", CurrentRequestViewModel = new BPURequestViewModel() },
                new ETsViewModel(){ ShortName = "ЭЦ", Title = "Заявки на обслуживание энергосистем" },
                new KBSTViewModel(){ ShortName = "КБСТ", Title = "Заявки на 3D модели" }
            };

            UpdateDataGrid = new UpdateDataGridCommand(this);
            OpenRequestWindow = new OpenRequestWindowCommand(this);
        }

        public ICommand UpdateDataGrid { get; set; }
        public ICommand OpenRequestWindow { get; set; }
        public List<DepartmentViewModel> ViewModelsList { get; }
        public bool ShowAllRequests { get; set; }

        public DepartmentViewModel SelectedViewModel
        {
            get => _selectedViewModel;
            set
            {
                _selectedViewModel = value;
                UpdateDataGrid.Execute(null);
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }
    }
}
