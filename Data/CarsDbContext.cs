using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Models;

namespace WinFormsApp1.Data;

public class CarsDbContext : DbContext
{
    public DbSet<Car> Cars { get; set; }
    public DbSet<Owner> Owners { get; set; }
    public DbSet<Service> Services { get; set; }
    public DbSet<CarService> CarServices { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CarsDB;Trusted_Connection=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>().ToTable("Cars");
        modelBuilder.Entity<Owner>().ToTable("Owners");
        modelBuilder.Entity<Service>().ToTable("Services");
        modelBuilder.Entity<CarService>().ToTable("CarServices");
        modelBuilder.Entity<CarService>().Property(t => t.DateOfService).HasDefaultValueSql("GETDATE()");
        modelBuilder.Entity<CarService>().HasKey(cs => new { cs.CarId, cs.ServiceId });
    }

    public void EnsureCreated()
    {
        Database.EnsureCreated();
    }
}
