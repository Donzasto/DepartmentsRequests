using DepartmentsRequests.Models;
using Microsoft.EntityFrameworkCore;

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
    }
}
