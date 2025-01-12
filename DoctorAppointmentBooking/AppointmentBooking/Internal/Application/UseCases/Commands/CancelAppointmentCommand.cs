using AppointmentBooking.Internal.Domain.Interfaces;
using AppointmentBooking.Public.DTOs.Requests;
using AppointmentBooking.Public.Interfaces.ICommands;

namespace AppointmentBooking.Internal.Application.UseCases.Commands;

internal class CancelAppointmentCommand(IAppointmentRepository appointmentRepository) : ICancelAppointmentCommand
{
    public async Task ExecuteAsync(CancelAppointmentRequest request)
    {
        var appointment = await appointmentRepository.GetAppointmentByIdAsync(request.AppointmentId);

        appointment?.Cancel();

        await appointmentRepository.SaveChangesAsync();
    }
}