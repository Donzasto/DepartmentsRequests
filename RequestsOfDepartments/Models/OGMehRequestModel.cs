using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DepartmentsRequests.Models
{
    [Table("RequestsOGMeh")]
    public class OGMehRequestModel
    {
        public int Id { get; set; }
        public string Equipment { get; set; }
        public int Department { get; set; }
        public string FullNameSender { get; set; }
        public string MailSender { get; set; }
        public string PhoneSender { get; set; }
        public string Order { get; set; }
        public string Specialist { get; set; }
        public string Description { get; set; }
        public string FullNameOperator { get; set; }
        public DateTime? DateProvide { get; set; }
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
    }
}
