using DepartmentsRequests.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DepartmentsRequests.DAL
{
    public class DepartmentsRequestsContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=productionsql;Database=production;Trusted_Connection=True;");
        }

        public DbSet<OGMehRequestModel> RequestsOGMeh { get; set; }
        public DbSet<BPURequestModel> RequestsBPU { get; set; }
        public DbSet<EquipmentModel> Equipment { get; set; }
        public DbSet<UserModel> User { get; set; }

        public List<int> DepartmentsList => User.Select(s => s.Department).Distinct().ToList();
        public List<EquipmentModel> EquipmentList => Equipment.OrderByDescending(o => o.Id).ToList();
        public List<OGMehRequestModel> OGMehOpenRequestsList => RequestsOGMeh.Where(w => w.DateClosed == null).OrderByDescending(o => o.Id).ToList();
        public List<OGMehRequestModel> OGMehAllRequestsList => RequestsOGMeh.OrderByDescending(o => o.Id).ToList();
        public List<BPURequestModel> BPUOpenRequestsList => RequestsBPU.Where(w => w.DateClosed == null).OrderByDescending(o => o.Id).ToList();
        public List<BPURequestModel> BPUAllRequestsList => RequestsBPU.OrderByDescending(o => o.Id).ToList();
    }
}
