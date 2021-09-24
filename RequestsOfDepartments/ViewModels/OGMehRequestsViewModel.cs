using RequestsOfDepartments.DAL;
using RequestsOfDepartments.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace RequestsOfDepartments.ViewModels
{
    public class OGMehRequestsViewModel : BaseRequestsViewModel
    {
        public OGMehRequestsViewModel()
        {
            using RequestsOfDepartmentsContext db = new();
        //    RequestsOfDepartmentsOGMeh = db.RequestsOfDepartmentsOGMeh.OrderByDescending(o => o.Id).ToList();
        }

        public ObservableCollection<RequestsOfDepartmentsOGMeh> RequestsOfDepartmentsOGMeh { get; set; }
    }
}