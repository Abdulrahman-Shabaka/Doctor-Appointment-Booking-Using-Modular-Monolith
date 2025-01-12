using DoctorAvailability.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorAvailability.Data;

internal class DoctorAvailabilityDbContext(DbContextOptions<DoctorAvailabilityDbContext> options) : DbContext(options)
{
    public DbSet<Slot?> Slots { get; set; }
}