using AppointmentBooking.Application.Shared.DTOs.Responses;
using AppointmentBooking.Application.Shared.Interfaces.IQueries;
using AppointmentBooking.Domain.Interfaces;
using AutoMapper;

namespace AppointmentBooking.Application.UseCases.Query;

internal class GetUpcomingAppointmentQueryQueryHandler(IAppointmentRepository appointmentRepository, IMapper mapper) : IGetUpcomingAppointmentQuery
{
    public async Task<List<AppointmentResponse>> ExecuteAsync()
    {
        var appointments = await appointmentRepository.GetUpcomingAppointmentAsync();

        return mapper.Map<List<AppointmentResponse>>(appointments);
    }
}