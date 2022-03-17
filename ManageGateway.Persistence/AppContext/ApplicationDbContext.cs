using ManageGateway.Domain.Models;
using ManageGateway.Persistence.Extensions;
using Microsoft.EntityFrameworkCore;

namespace ManageGateway.Persistence.AppContext
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Gateway> Gateways { get; set; }
        public DbSet<Device> Devices { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Device>()
                .HasOne(g => g.Gateway)
                .WithMany(d => d.Devices)
                .HasForeignKey(d => d.GatewaySerialNumber);

            modelBuilder.Entity<Device>()
                .Property(d => d.Status)
                .HasConversion<int>();

            // Initialize DB with data
            modelBuilder.Seed();
        }
    }
}
