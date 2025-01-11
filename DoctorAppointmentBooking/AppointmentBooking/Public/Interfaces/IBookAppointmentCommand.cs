using AppointmentBooking.Public.Requests;
using AppointmentBooking.Public.Responses;

namespace AppointmentBooking.Public.Interfaces;

public interface IBookAppointmentCommand
{
    Task<AppointmentResponse> ExecuteAsync(BookAppointmentRequest request);
}