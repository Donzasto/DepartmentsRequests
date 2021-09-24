using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using RequestsOfDepartments.Models;

namespace RequestsOfDepartments.ViewModels
{
    public class MainWindowViewModel : BaseRequestsViewModel
    {
        private BaseRequestsViewModel _selectedDepartment;

        public MainWindowViewModel()
        {
            Departments = new ObservableCollection<Departments>()
            {
                new Departments() { ShortName = "ОГМех", RequestsViewModel = new OGMehRequestsViewModel() },
                new Departments() { ShortName = "БПУ", RequestsViewModel = new BPURequestsViewModel() },
                new Departments() { ShortName = "ЭЦ", RequestsViewModel = new ETsRequestsViewModel() },
                new Departments() { ShortName = "КБСТ", RequestsViewModel = new KBSTRequestsViewModel() }
            };
        }

        public ObservableCollection<Departments> Departments { get; }

        public BaseRequestsViewModel SelectedViewModel
        {
            get { return _selectedDepartment; }
            set
            {
                _selectedDepartment = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }
    }
}
