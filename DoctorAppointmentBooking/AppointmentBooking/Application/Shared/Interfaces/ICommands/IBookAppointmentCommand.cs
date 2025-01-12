using AppointmentBooking.Application.Shared.DTOs.Requests;
using AppointmentBooking.Application.Shared.DTOs.Responses;

namespace AppointmentBooking.Application.Shared.Interfaces.ICommands;

public interface IBookAppointmentCommand
{
    Task<AppointmentResponse> ExecuteAsync(BookAppointmentRequest request);
}