using DepartmentsRequests.ViewModels.RequestWindow;

namespace DepartmentsRequests.ViewModels
{
    public abstract class DepartmentViewModel : BaseViewModel
    {
        public string Title { get; set; }
        public string ShortName { get; set; }
        internal RequestViewModel CurrentRequestViewModel { get; set; }
    }
}
