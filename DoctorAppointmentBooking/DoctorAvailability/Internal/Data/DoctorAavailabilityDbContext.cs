using DoctorAvailability.Internal.Models;

using Microsoft.EntityFrameworkCore;

namespace DoctorAvailability.Internal.Data;

internal class DoctorAvailabilityDbContext(DbContextOptions<DoctorAvailabilityDbContext> options) : DbContext(options)
{
    public DbSet<Slot?> Slots { get; set; }
}