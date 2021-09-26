using DepartmentsRequests.ViewModels;

namespace DepartmentsRequests.Models
{
    public class Department
    {
        public string ShortName { get; set; }
        public string Description { get; set; }
        public BaseViewModel RequestsViewModel { get; set; }
    }
}