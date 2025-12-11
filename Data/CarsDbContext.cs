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
        if (Owners.Count() != 0 && Cars.Count() != 0)
            return;

        Owners.Add(new Owner { FullName = "Artjom Põldsaar", Phone = "+123 456 789" });
        Owners.Add(new Owner { FullName = "Vadim Gruzovik", Phone = "+666 555 444" });
        Owners.Add(new Owner { FullName = "V. V. Putin", Phone = "+3 723 723" });

        SaveChanges();

        Cars.Add(new Car { Brand = "BMW", Model = "1", RegistrationNumber = "777 SSS", OwnerId = 1 });
        Cars.Add(new Car { Brand = "Mercedes", Model = "A Class", RegistrationNumber = "123 OPP", OwnerId = 2 });
        Cars.Add(new Car { Brand = "Mercedes", Model = "G Class", RegistrationNumber = "к213нр 62", OwnerId = 3 });

        SaveChanges();

        Services.Add(new Service { Name = "Rehvi vahetus", Price = 40 });
        Services.Add(new Service { Name = "Auto pesemine", Price = 20 });
        Services.Add(new Service { Name = "Õlivahetus", Price = 49 });

        SaveChanges();

        CarServices.Add(new CarService { CarId = 1, ServiceId = 1, DateOfService = DateTime.Now, PaidPrice = 40, Paid = true });
        CarServices.Add(new CarService { CarId = 2, ServiceId = 1, DateOfService = DateTime.UtcNow, PaidPrice = 35.99f, Paid = true });
        CarServices.Add(new CarService { CarId = 3, ServiceId = 2, DateOfService = new DateTime(2025, 6, 5, 12, 30, 0), PaidPrice = 0, Paid = false });
        
        SaveChanges();
    }
}
