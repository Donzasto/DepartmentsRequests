using System.Collections.Generic;

namespace DepartmentsRequests.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private BaseViewModel _selectedViewModel;
        private string _department;

        public MainWindowViewModel()
        {
            Departments = new List<string>()
            {
                "ОГМех",
                "БПУ",
                "ЭЦ",
                "КБСТ"
            };
        }

        public List<string> Departments { get; }

        public string SelectedDepartment
        {
            get => _department;
            set
            {
                _department = value;

                if (_department == "ОГМех")
                {
                    SelectedViewModel = new OGMehViewModel("Заявки на ремонт оборудования");
                }
                else if (_department == "БПУ")
                {
                    SelectedViewModel = new BPUViewModel("Заявки на управлющие программы");
                }
                else if (_department == "ЭЦ")
                {
                    SelectedViewModel = new ETsViewModel("Заявки на обслуживание энергосистем");
                }
                else if (_department == "КБСТ")
                {
                    SelectedViewModel = new KBSTViewModel("Заявки на 3D модели");
                }
            }
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
    }
}
