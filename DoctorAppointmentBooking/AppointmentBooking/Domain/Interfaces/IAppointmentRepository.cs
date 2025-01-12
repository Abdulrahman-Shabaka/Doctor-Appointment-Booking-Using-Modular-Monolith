using AppointmentBooking.Domain.Models;

namespace AppointmentBooking.Domain.Interfaces;

internal interface IAppointmentRepository
{
    Task AddAppointment(Appointment appointment);
    Task<Appointment?> GetAppointmentByIdAsync(Guid id);
    Task<List<Appointment>> GetAppointmentsByPatientIdAsync(Guid patientId);
    Task SaveChangesAsync();
    Task<List<Appointment>> GetUpcomingAppointmentAsync();
}