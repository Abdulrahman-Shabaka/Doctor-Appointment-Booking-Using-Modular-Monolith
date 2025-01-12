using AppointmentBooking.Internal.Domain.Interfaces;
using AppointmentBooking.Internal.Domain.Models;
using AppointmentBooking.Public.DTOs.Requests;
using AppointmentBooking.Public.DTOs.Responses;
using AppointmentBooking.Public.Events;
using AppointmentBooking.Public.Interfaces.ICommands;
using AutoMapper;

using DoctorAvailability.Public.Interfaces;

using SharedKernel.Events;

namespace AppointmentBooking.Internal.Application.UseCases.Commands;

internal class BookAppointmentCommandHandler(
    IAppointmentRepository appointmentRepository,
    IDoctorAvailabilityService doctorAvailabilityService,
    IMapper mapper,
    EventDispatcher eventDispatcher) : IBookAppointmentCommand
{
    public async Task<AppointmentResponse> ExecuteAsync(BookAppointmentRequest request)
    {
        var slot = await doctorAvailabilityService.GetSlotIfAvailableAsync(request.SlotId);

        var appointment = mapper.Map<Appointment>(request);

        await appointmentRepository.AddAppointment(appointment);

        await appointmentRepository.SaveChangesAsync();

        await doctorAvailabilityService.ReserveSlotAsync(request.SlotId);

        var @event = new AppointmentBookedEvent(
            appointment.Id,
            appointment.SlotId,
            appointment.PatientId,
            appointment.PatientName,
            slot.Time,
            slot.DoctorName
        );

        eventDispatcher.Dispatch(@event);

        return mapper.Map<AppointmentResponse>(appointment);
    }
}