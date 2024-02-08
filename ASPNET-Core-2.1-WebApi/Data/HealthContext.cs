using HealthAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthAPI.Data
{
    public class HealthContext : DbContext
    {
        public HealthContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Ailment> Ailments { get; set; }
        public DbSet<Medication> Medications { get; set; }
        public DbSet<Patient> Patients { get; set; }

    }
}
