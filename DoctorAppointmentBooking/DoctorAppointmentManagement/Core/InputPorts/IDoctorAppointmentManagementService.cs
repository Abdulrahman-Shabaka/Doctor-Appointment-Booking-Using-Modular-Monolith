using DoctorAppointmentManagement.Core.DTOs;

namespace DoctorAppointmentManagement.Core.InputPorts;

public interface IDoctorAppointmentManagementService
{
    Task<List<AppointmentDto>> GetUpcomingAppointmentsAsync();
}