using DepartmentsRequests.Commands;
using DepartmentsRequests.DAL;
using System.Collections.Generic;
using System.Windows.Input;

namespace DepartmentsRequests.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private BaseViewModel _selectedViewModel;

        public List<BaseViewModel> ViewModelsList { get; }

        public MainWindowViewModel()
        {
            using DepartmentsRequestsContext db = new();

            ViewModelsList = new List<BaseViewModel>()
            {
                new OGMehViewModel(){ ShortName = "ОГМех", Title = "Заявки на ремонт оборудования", OGMehRequestsDataGrid = db.OGMehRequestsList },
                new BPUViewModel(){ ShortName = "БПУ", Title =  "Заявки на управлющие программы", BPURequestsDataGrid = db.BPURequestsList },
                new ETsViewModel(){ ShortName = "ЭЦ", Title = "Заявки на обслуживание энергосистем" },
                new KBSTViewModel(){ ShortName = "КБСТ", Title = "Заявки на 3D модели" }
            };

            UpdateDataGrid = new UpdateDataGrid(this);
        }

        public BaseViewModel SelectedViewModel
        {
            get => _selectedViewModel;
            set
            {
                _selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }

        public ICommand UpdateDataGrid { get; set; }

        public bool IsShowAllRequests { get; set; }
    }
}
