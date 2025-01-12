using AppointmentBooking.Application.Shared.Interfaces.IQueries;

using AutoMapper;

using DoctorAppointmentManagement.Core.DTOs;
using DoctorAppointmentManagement.Core.OutputPorts;

namespace DoctorAppointmentManagement.Shell.Services;

internal class AppointmentService(IGetUpcomingAppointmentQuery query, IMapper mapper) : IAppointmentService
{
    public async Task<List<AppointmentDto>> GetUpcomingAppointmentsAsync()
    {
        var appointments =  await query.ExecuteAsync();
        return mapper.Map<List<AppointmentDto>>(appointments);
    }
}