using AppointmentBooking.Application.Shared.DTOs.Requests;

namespace AppointmentBooking.Application.Shared.Interfaces.ICommands;

public interface ICompleteAppointmentCommand
{
    Task ExecuteAsync(CompleteAppointmentRequest request);
}