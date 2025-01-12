using AppointmentBooking.Public.DTOs.Requests;

namespace AppointmentBooking.Public.Interfaces.ICommands;

public interface ICancelAppointmentCommand
{
    Task ExecuteAsync(CancelAppointmentRequest request);
}