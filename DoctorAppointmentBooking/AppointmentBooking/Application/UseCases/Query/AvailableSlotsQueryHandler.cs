using AppointmentBooking.Application.Shared.Interfaces.IQueries;
using DoctorAvailability.Shared.DTOs.Response;
using DoctorAvailability.Shared.Interfaces;

namespace AppointmentBooking.Application.UseCases.Query;

internal class AvailableSlotsQueryHandler(IDoctorAvailabilityService doctorAvailabilityService) : IAvailableSlotsQuery
{
    public async Task<List<SlotResponse>> ExecuteAsync()
    {
        var availableSlots = await doctorAvailabilityService.GetAvailableSlotsAsync();

        return availableSlots;
    }
}