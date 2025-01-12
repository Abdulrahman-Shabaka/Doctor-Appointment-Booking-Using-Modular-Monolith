using DoctorAppointmentManagement.Core.DTOs;

namespace DoctorAppointmentManagement.Core.OutputPorts;

internal interface IAppointmentService
{
    Task<List<AppointmentDto>> GetUpcomingAppointmentsAsync();
    Task CompleteAppointmentAsync(CompleteAppointmentDto completeAppointmentDto);
    Task CancelAppointmentAsync(CancelAppointmentDto cancelAppointmentDto);
}