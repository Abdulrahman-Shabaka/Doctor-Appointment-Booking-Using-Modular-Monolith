using AppointmentBooking.Internal.Domain.Models;

using Microsoft.EntityFrameworkCore;

namespace AppointmentBooking.Internal.Infrastructure;

internal class AppointmentDbContext(DbContextOptions<AppointmentDbContext> options) : DbContext(options)
{
    public DbSet<Appointment> Appointments { get; set; }
}