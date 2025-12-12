using eVehicle.Models;
using Microsoft.EntityFrameworkCore;

namespace eVehicle.Repositories
{
    public class eVehicleDBContext:DbContext
    {
        public eVehicleDBContext():base()
        {
            
        }
        public eVehicleDBContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Brand>();
            modelBuilder.Entity<Color>();
            modelBuilder.Entity<Vehicle>();
            modelBuilder.Entity<VehicleType>();
        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleType> VehicleTypes { get; set; }
    }
}
