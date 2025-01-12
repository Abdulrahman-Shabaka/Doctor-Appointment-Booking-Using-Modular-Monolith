using AppointmentBooking.Internal.Domain.Interfaces;
using AppointmentBooking.Internal.Domain.Models;

using Microsoft.EntityFrameworkCore;

namespace AppointmentBooking.Internal.Infrastructure.Repositories;

internal class AppointmentRepository(AppointmentDbContext dbContext) : IAppointmentRepository
{
    public async Task AddAppointment(Appointment appointment)
    {
       await dbContext.AddAsync(appointment);
    }

    public async Task<Appointment?> GetAppointmentByIdAsync(Guid id)
    {
        return await dbContext.Set<Appointment>().FindAsync(id);
    }

    public async Task<List<Appointment>> GetAppointmentsByPatientIdAsync(Guid patientId)
    {
        return await dbContext.Set<Appointment>()
            .Where(a => a.PatientId == patientId)
            .ToListAsync();
    }

    public async Task SaveChangesAsync()
    {
        await dbContext.SaveChangesAsync();
    }
}