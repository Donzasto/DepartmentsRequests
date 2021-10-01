using DepartmentsRequests.Commands;
using System.Collections.Generic;
using System.Windows.Input;

namespace DepartmentsRequests.ViewModels
{
    public class MainWindowViewModel : DepartmentViewModel
    {
        private DepartmentViewModel _selectedViewModel;

        public ICommand UpdateDataGrid { get; set; }
        public ICommand OpenRequestWindow { get; set; }
        public List<DepartmentViewModel> ViewModelsList { get; }
        public bool IsShowAllRequests { get; set; }

        public MainWindowViewModel()
        {
            ViewModelsList = new List<DepartmentViewModel>()
            {
                new OGMehViewModel(){ ShortName = "ОГМех", Title = "Заявки на ремонт оборудования" },
                new BPUViewModel(){ ShortName = "БПУ", Title =  "Заявки на управлющие программы" },
                new ETsViewModel(){ ShortName = "ЭЦ", Title = "Заявки на обслуживание энергосистем" },
                new KBSTViewModel(){ ShortName = "КБСТ", Title = "Заявки на 3D модели" }
            };

            UpdateDataGrid = new UpdateDataGrid(this);
            OpenRequestWindow = new OpenRequestWindow();
        }

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
