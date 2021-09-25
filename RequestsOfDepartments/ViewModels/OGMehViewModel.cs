using DepartmentsRequests.DAL;
using DepartmentsRequests.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace DepartmentsRequests.ViewModels
{
    public class OGMehViewModel : BaseViewModel
    {
        public OGMehViewModel(string title) : base(title)
        {
            using DepartmentsRequestsContext db = new();
            //RequestsOGMeh = db.RequestsOGMeh.OrderByDescending(o => o.Id).ToList();
        }

        public List<OGMehRequestModel> RequestsOGMeh { get; set; }
    }
}