using DepartmentsRequests.Commands;
using DepartmentsRequests.DAL;
using System.Collections.Generic;
using System.Windows.Input;

namespace DepartmentsRequests.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private BaseViewModel _selectedViewModel;

        public ICommand UpdateDataGrid { get; set; }
        public ICommand OpenRequestWindow { get; set; }
        public List<BaseViewModel> ViewModelsList { get; }
        public bool IsShowAllRequests { get; set; }

        public MainWindowViewModel()
        {
            using DepartmentsRequestsContext db = new();

            ViewModelsList = new List<BaseViewModel>()
            {
                new OGMehViewModel(){ ShortName = "ОГМех", Title = "Заявки на ремонт оборудования" },
                new BPUViewModel(){ ShortName = "БПУ", Title =  "Заявки на управлющие программы" },
                new ETsViewModel(){ ShortName = "ЭЦ", Title = "Заявки на обслуживание энергосистем" },
                new KBSTViewModel(){ ShortName = "КБСТ", Title = "Заявки на 3D модели" }
            };

            UpdateDataGrid = new UpdateDataGrid(this);
            OpenRequestWindow = new OpenRequestWindow();
        }

        public BaseViewModel SelectedViewModel
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
