using AppointmentBooking.Application.Shared.DTOs.Requests;
using AppointmentBooking.Application.Shared.Interfaces.ICommands;
using AppointmentBooking.Domain.Interfaces;

namespace AppointmentBooking.Application.UseCases.Commands;

internal class CompleteAppointmentCommand(IAppointmentRepository appointmentRepository) : ICompleteAppointmentCommand
{
    public async Task ExecuteAsync(CompleteAppointmentRequest request)
    {
        var appointment = await appointmentRepository.GetAppointmentByIdAsync(request.AppointmentId);

        appointment?.Complete();

        await appointmentRepository.SaveChangesAsync();
    }
}