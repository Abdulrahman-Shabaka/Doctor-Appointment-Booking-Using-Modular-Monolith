using AppointmentBooking.Internal.Domain.Interfaces;
using AppointmentBooking.Internal.Domain.Models;
using AppointmentBooking.Public.Interfaces;
using AppointmentBooking.Public.Requests;
using AppointmentBooking.Public.Responses;
using AutoMapper;
using DoctorAvailability.Public.Interfaces;

namespace AppointmentBooking.Internal.Application.UseCases.Commands;

internal class BookAppointmentCommandHandler(
    IAppointmentRepository appointmentRepository,
    IDoctorAvailabilityService doctorAvailabilityService,
    IMapper mapper) : IBookAppointmentCommand
{
    public async Task<AppointmentResponse> ExecuteAsync(BookAppointmentRequest request)
    {
        await doctorAvailabilityService.ValidateSlotAvailabilityAsync(request.SlotId);


        var appointment = mapper.Map<Appointment>(request);

        await appointmentRepository.AddAppointment(appointment);

        await appointmentRepository.SaveChangesAsync();

        await doctorAvailabilityService.ReserveSlotAsync(request.SlotId);

        return mapper.Map<AppointmentResponse>(appointment);
    }
}