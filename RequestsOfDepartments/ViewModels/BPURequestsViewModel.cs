using RequestsOfDepartments.DAL;
using RequestsOfDepartments.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace RequestsOfDepartments.ViewModels
{
    public class BPURequestsViewModel : BaseRequestsViewModel
    {
        public BPURequestsViewModel()
        {
            using RequestsOfDepartmentsContext db = new();
        //    RequestsOfDepartmentsBPU = db.RequestsOfDepartmentsBPU.OrderByDescending(o => o.Id).ToList();
        }

        public ObservableCollection<RequestsOfDepartmentsBPU> RequestsOfDepartmentsBPU { get; set; }
    }
}
