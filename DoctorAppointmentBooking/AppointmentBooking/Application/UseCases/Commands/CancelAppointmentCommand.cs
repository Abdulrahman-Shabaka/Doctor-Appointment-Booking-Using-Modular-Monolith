using AppointmentBooking.Application.Shared.DTOs.Requests;
using AppointmentBooking.Application.Shared.Interfaces.ICommands;
using AppointmentBooking.Domain.Interfaces;

namespace AppointmentBooking.Application.UseCases.Commands;

internal class CancelAppointmentCommand(IAppointmentRepository appointmentRepository) : ICancelAppointmentCommand
{
    public async Task ExecuteAsync(CancelAppointmentRequest request)
    {
        var appointment = await appointmentRepository.GetAppointmentByIdAsync(request.AppointmentId);

        appointment?.Cancel();

        await appointmentRepository.SaveChangesAsync();
    }
}