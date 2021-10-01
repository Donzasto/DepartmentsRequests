using DepartmentsRequests.Commands;
using DepartmentsRequests.DAL;
using DepartmentsRequests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace DepartmentsRequests.ViewModels
{
    public class RequestViewModel : BaseViewModel
    {
        private string _equipment;

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

        public RequestViewModel()
        {
            Equipment = _equipment;

            using DepartmentsRequestsContext departmentsRequestsContext = new();

            DepartmentsList = departmentsRequestsContext.DepartmentsList;

            AddRequest = new AddRequest(this);
        }
    }
}
