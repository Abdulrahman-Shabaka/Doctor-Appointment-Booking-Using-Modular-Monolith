using DoctorAppointmentManagement.Core.DTOs;
using DoctorAppointmentManagement.Core.InputPorts;
using DoctorAppointmentManagement.Core.OutputPorts;

namespace DoctorAppointmentManagement.Core.Services;

internal class DoctorAppointmentManagementService(IAppointmentService appointmentService) : IDoctorAppointmentManagementService
{
    public async Task<List<AppointmentDto>> GetUpcomingAppointmentsAsync()
    {
        var appointments = await appointmentService.GetUpcomingAppointmentsAsync();

        return appointments;
    }

    public async Task CompleteAppointmentAsync(CompleteAppointmentDto request)
    {
        await appointmentService.CompleteAppointmentAsync(request);
    }

    public async Task CancelAppointmentAsync(CancelAppointmentDto request)
    {
        await appointmentService.CancelAppointmentAsync(request);
    }
}