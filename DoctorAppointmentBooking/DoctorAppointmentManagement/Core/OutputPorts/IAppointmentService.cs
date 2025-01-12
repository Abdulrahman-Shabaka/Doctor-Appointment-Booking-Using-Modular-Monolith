using AppointmentBooking.Application.Shared.DTOs.Responses;

using DoctorAppointmentManagement.Core.DTOs;

namespace DoctorAppointmentManagement.Core.OutputPorts;

internal interface IAppointmentService
{
    Task<List<AppointmentDto>> GetUpcomingAppointmentsAsync();
}