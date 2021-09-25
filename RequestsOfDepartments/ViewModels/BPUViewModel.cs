using DepartmentsRequests.DAL;
using DepartmentsRequests.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace DepartmentsRequests.ViewModels
{
    public class BPUViewModel : BaseViewModel
    {
        public BPUViewModel(string title) : base(title)
        {
            using DepartmentsRequestsContext db = new();
            //    RequestsBPU = db.RequestsBPU.OrderByDescending(o => o.Id).ToList();
        }

        public List<BPURequestModel> RequestsOfDepartmentsBPU { get; set; }
    }
}
