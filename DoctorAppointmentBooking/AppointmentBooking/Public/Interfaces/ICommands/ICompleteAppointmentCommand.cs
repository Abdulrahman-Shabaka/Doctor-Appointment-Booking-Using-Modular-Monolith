using System.Reflection.Metadata.Ecma335;
using AppointmentBooking.Public.DTOs.Requests;

namespace AppointmentBooking.Public.Interfaces.ICommands;

public interface ICompleteAppointmentCommand
{
    Task ExecuteAsync(CompleteAppointmentRequest request);
}