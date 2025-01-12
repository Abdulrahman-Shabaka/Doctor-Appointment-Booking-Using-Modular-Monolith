using AppointmentBooking.Public.DTOs.Requests;
using AppointmentBooking.Public.DTOs.Responses;

namespace AppointmentBooking.Public.Interfaces.ICommands;

public interface IBookAppointmentCommand
{
    Task<AppointmentResponse> ExecuteAsync(BookAppointmentRequest request);
}