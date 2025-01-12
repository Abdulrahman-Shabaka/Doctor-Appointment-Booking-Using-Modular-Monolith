using AppointmentBooking.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace AppointmentBooking.Infrastructure;

internal class AppointmentDbContext(DbContextOptions<AppointmentDbContext> options) : DbContext(options)
{
    public DbSet<Appointment> Appointments { get; set; }
}