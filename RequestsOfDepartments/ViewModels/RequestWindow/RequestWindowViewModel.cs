using System;
using System.Collections.Generic;
using System.Windows.Input;
using DepartmentsRequests.Commands;
using DepartmentsRequests.DAL;
using DepartmentsRequests.Models;

namespace DepartmentsRequests.ViewModels.RequestWindow
{
    public class RequestWindowViewModel
    {
        public RequestWindowViewModel()
        {
            using DepartmentsRequestsContext departmentsRequestsContext = new();

            DepartmentsList = departmentsRequestsContext.DepartmentsList;

            AddRequest = new AddRequestCommand(this);
        }

        public ICommand AddRequest { get; set; }
        public List<int> DepartmentsList { get; }
        public List<EquipmentModel> EquipmentList { get; }
        public List<string> FullNameSendersList { get; }
        public List<string> FullNameOperatorsList { get; }
        public int Department { get; set; }
        public string Equipment { get; set; }
        public string FullNameSender { get; set; }
        public string MailSender { get; set; }
        public string PhoneSender { get; set; }
        public string Order { get; set; }
        public string Specialist { get; set; }
        public string Description { get; set; }
        public string FullNameOperator { get; set; }
        public DateTime? DateProvide { get; set; }

        public OGMehRequestViewModel SelectedViewModel { get; set; } = new OGMehRequestViewModel();
    }
}
