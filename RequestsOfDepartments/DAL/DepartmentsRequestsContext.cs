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

     //   public List<OGMehRequestModel> OGMehRequestsList => RequestsOGMeh.OrderByDescending(o => o.Id).ToList();

     //   public List<BPURequestModel> BPURequestsList => RequestsBPU.OrderByDescending(o => o.Id).ToList();
    }
}
