using System.ComponentModel.DataAnnotations.Schema;

namespace DepartmentsRequests.Models
{
    [Table("RequestsEquipment")]
    public class EquipmentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string InventoryNumber { get; set; }
        public string Department { get; set; }
    }
}
