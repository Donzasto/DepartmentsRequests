using DepartmentsRequests.Models;
using System.Collections.Generic;

namespace DepartmentsRequests.ViewModels.MainWindow
{
    public class OGMehViewModel : DepartmentViewModel
    {
        private List<OGMehRequestModel> _oGMehRequestModel;

        public List<OGMehRequestModel> OGMehDataGrid
        {
            get => _oGMehRequestModel;
            set
            {
                _oGMehRequestModel = value;
                OnPropertyChanged(nameof(OGMehDataGrid));
            }
        }
    }
}