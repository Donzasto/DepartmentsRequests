using RequestsOfDepartments.ViewModels;

namespace RequestsOfDepartments.Models
{
    public class Departments
    {
        public string ShortName { get; set; }
        public BaseRequestsViewModel RequestsViewModel { get; set; }
    }
}