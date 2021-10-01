using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DepartmentsRequests.Models
{
    [Table("RequestsBPU")]
    public class BPURequestModel
    {
        public int Id { get; set; }
        public string Equipment { get; set; }
        public int Department { get; set; }
        public string FullNameSender { get; set; }
        public string PhoneSender { get; set; }
        public string Order { get; set; }
        public DateTime? DateSended { get; set; }
        public string FullNameImplementation { get; set; }
        public DateTime? DatePlan { get; set; }
        public DateTime? DateReceived { get; set; }
        public string NoteBPU { get; set; }
        public DateTime? DatePresented { get; set; }
        public string FullNameCloser { get; set; }
        public DateTime? DateClosed { get; set; }
        public string DecNum { get; set; }
        public string NoteBPUAccepted { get; set; }
    }
}
