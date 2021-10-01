using System.ComponentModel.DataAnnotations.Schema;

namespace DepartmentsRequests.Models
{
    [Table("RequestsUsers")]
    public class UserModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Department { get; set; }
        public string Role { get; set; }
    }
}
