using DepartmentsRequests.Models;
using System.Collections.Generic;

namespace DepartmentsRequests.ViewModels
{
    public class BPUViewModel : BaseViewModel
    {
        private List<BPURequestModel> _bPURequestModel;

        public List<BPURequestModel> BPURequestsDataGrid
        {
            get => _bPURequestModel;
            set
            {
                _bPURequestModel = value;
                OnPropertyChanged(nameof(BPURequestsDataGrid));
            }
        }
    }
}
