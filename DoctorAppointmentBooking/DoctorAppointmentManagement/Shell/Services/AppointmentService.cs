using AppointmentBooking.Application.Shared.DTOs.Requests;
using AppointmentBooking.Application.Shared.Interfaces.ICommands;
using AppointmentBooking.Application.Shared.Interfaces.IQueries;

using AutoMapper;

using DoctorAppointmentManagement.Core.DTOs;
using DoctorAppointmentManagement.Core.OutputPorts;

namespace DoctorAppointmentManagement.Shell.Services;

internal class AppointmentService(
    IGetUpcomingAppointmentQuery getUpcomingAppointmentQuery,
    ICompleteAppointmentCommand completeAppointmentCommand,
    ICancelAppointmentCommand cancelAppointmentCommand,
    IMapper mapper) : IAppointmentService
{
    public async Task<List<AppointmentDto>> GetUpcomingAppointmentsAsync()
    {
        var appointments =  await getUpcomingAppointmentQuery.ExecuteAsync();
        return mapper.Map<List<AppointmentDto>>(appointments);
    }

    public async Task CompleteAppointmentAsync(CompleteAppointmentDto completeAppointmentDto)
    {
        var request = mapper.Map<CompleteAppointmentRequest>(completeAppointmentDto);
        await completeAppointmentCommand.ExecuteAsync(request);
    }

    public async Task CancelAppointmentAsync(CancelAppointmentDto cancelAppointmentDto)
    {
        var request = mapper.Map<CancelAppointmentRequest>(cancelAppointmentDto);
        await cancelAppointmentCommand.ExecuteAsync(request);
    }
}