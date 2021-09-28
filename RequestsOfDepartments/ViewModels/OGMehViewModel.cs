using DepartmentsRequests.Models;
using System.Collections.Generic;

namespace DepartmentsRequests.ViewModels
{
    public class OGMehViewModel : BaseViewModel
    {
        private List<OGMehRequestModel> _oGMehRequestModel;

        public List<OGMehRequestModel> OGMehRequestsDataGrid
        {
            get => _oGMehRequestModel;
            set
            {
                _oGMehRequestModel = value;
                OnPropertyChanged(nameof(OGMehRequestsDataGrid));
            }
        }
    }
}