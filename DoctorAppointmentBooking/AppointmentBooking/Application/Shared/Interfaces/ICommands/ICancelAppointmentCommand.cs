using AppointmentBooking.Application.Shared.DTOs.Requests;

namespace AppointmentBooking.Application.Shared.Interfaces.ICommands;

public interface ICancelAppointmentCommand
{
    Task ExecuteAsync(CancelAppointmentRequest request);
}