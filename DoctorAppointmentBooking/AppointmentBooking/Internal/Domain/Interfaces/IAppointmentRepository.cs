using AppointmentBooking.Internal.Domain.Models;

namespace AppointmentBooking.Internal.Domain.Interfaces;

internal interface IAppointmentRepository
{
    Task AddAppointment(Appointment appointment);
    Task<List<Appointment>> GetAppointmentsByPatientIdAsync(Guid patientId);
    Task SaveChangesAsync();
}