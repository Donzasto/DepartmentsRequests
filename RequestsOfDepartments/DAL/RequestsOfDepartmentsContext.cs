using Microsoft.EntityFrameworkCore;
using RequestsOfDepartments.Models;

namespace RequestsOfDepartments.DAL
{
    public class RequestsOfDepartmentsContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=productionsql;Database=production;Trusted_Connection=True;");
        }

        public DbSet<RequestsOfDepartmentsOGMeh> RequestsOfDepartmentsOGMeh { get; set; }
        public DbSet<RequestsOfDepartmentsBPU> RequestsOfDepartmentsBPU { get; set; }
    }
}
