using AppointmentBooking.Internal.Domain.Interfaces;
using AppointmentBooking.Public.DTOs.Requests;
using AppointmentBooking.Public.Interfaces.ICommands;

namespace AppointmentBooking.Internal.Application.UseCases.Commands;

internal class CompleteAppointmentCommand(IAppointmentRepository appointmentRepository) : ICompleteAppointmentCommand
{
    public async Task ExecuteAsync(CompleteAppointmentRequest request)
    {
        var appointment = await appointmentRepository.GetAppointmentByIdAsync(request.AppointmentId);

        appointment?.Complete();

        await appointmentRepository.SaveChangesAsync();
    }
}