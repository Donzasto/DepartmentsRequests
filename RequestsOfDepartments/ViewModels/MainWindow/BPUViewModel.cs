using DepartmentsRequests.Models;
using System.Collections.Generic;

namespace DepartmentsRequests.ViewModels.MainWindow
{
    public class BPUViewModel : DepartmentViewModel
    {
        private List<BPURequestModel> _bPURequestModel;

        public List<BPURequestModel> BPUDataGrid
        {
            get => _bPURequestModel;
            set
            {
                _bPURequestModel = value;
                OnPropertyChanged(nameof(BPUDataGrid));
            }
        }
    }
}
