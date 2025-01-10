using DoctorAvailability.Internal.Domain.Slots;
using Microsoft.EntityFrameworkCore;

namespace DoctorAvailability.Internal.Infrastructure.Persistence;

internal class DoctorAvailabilityDbContext(DbContextOptions<DoctorAvailabilityDbContext> options) : DbContext(options)
{
    public DbSet<Slot> Slots {get; set;}

     protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Slot>().HasData(
            new Slot()
            {
                Id = Guid.NewGuid(),
                Time = new DateTime(2025, 1, 10, 9, 0, 0), // 10th Jan 2025, 9:00 AM
                DoctorId = Guid.NewGuid(),
                DoctorName = "Dr. Smith",
                IsReserved = false,
                Cost = 150.00m
            },
            new Slot
            {
                Id = Guid.NewGuid(),
                Time = new DateTime(2025, 1, 10, 10, 0, 0), // 10th Jan 2025, 10:00 AM
                DoctorId = Guid.NewGuid(),
                DoctorName = "Dr. Jones",
                IsReserved = true,
                Cost = 200.00m
            },
            new Slot
            {
                Id = Guid.NewGuid(),
                Time = new DateTime(2025, 1, 10, 11, 0, 0), // 10th Jan 2025, 11:00 AM
                DoctorId = Guid.NewGuid(),
                DoctorName = "Dr. Taylor",
                IsReserved = false,
                Cost = 180.00m
            },
            new Slot
            {
                Id = Guid.NewGuid(),
                Time = new DateTime(2025, 1, 11, 9, 0, 0), // 11th Jan 2025, 9:00 AM
                DoctorId = Guid.NewGuid(),
                DoctorName = "Dr. Wilson",
                IsReserved = false,
                Cost = 160.00m
            });
    }
}