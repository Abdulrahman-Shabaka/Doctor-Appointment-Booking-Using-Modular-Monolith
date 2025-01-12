using AppointmentBooking.Application.Shared.DTOs.Responses;

namespace AppointmentBooking.Application.Shared.Interfaces.IQueries;

public interface IGetUpcomingAppointmentQuery
{
    Task<List<AppointmentResponse>> ExecuteAsync();
}