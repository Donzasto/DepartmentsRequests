using Microsoft.EntityFrameworkCore;
using System;

namespace DepartmentsRequests.Models
{
    public class OGMehRequestModel
    {
        public int Id { get; set; }
        public string Equipment { get; set; }
        public int Department { get; set; }
        public string FullNameSender { get; set; }
        public string Mail { get; set; }
        public string Description { get; set; }
        public string DescriptionExtra { get; set; }
        public string Operator { get; set; }
        public DateTime DateSended { get; set; }
        public DateTime DateProvide { get; set; }
        public string Priority { get; set; }
        public string RepairDepartment { get; set; }
        public string FullNameReceiver { get; set; }
        public DateTime? DateReceived { get; set; }
        public string FullNameImplementation { get; set; }
        public DateTime? DatePlanRepair { get; set; }
        public DateTime? DateEndRepair { get; set; }
        public string FullNamePresentated { get; set; }
        public string FullNameCloser { get; set; }
        public DateTime? DateClosed { get; set; }
        public string СompletedWork { get; set; }
        public string Spares { get; set; }
        public string MailReceiver { get; set; }
        public string PhoneSender { get; set; }
        public string Order { get; set; }
    }
}
