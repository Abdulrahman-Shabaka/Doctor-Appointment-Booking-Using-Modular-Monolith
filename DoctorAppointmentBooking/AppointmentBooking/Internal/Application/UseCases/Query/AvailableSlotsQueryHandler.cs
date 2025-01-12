using AppointmentBooking.Public.Interfaces;
using DoctorAvailability.Public.DTOs.Response;
using DoctorAvailability.Public.Interfaces;

namespace AppointmentBooking.Internal.Application.UseCases.Query;

internal class AvailableSlotsQueryHandler(IDoctorAvailabilityService doctorAvailabilityService) : IAvailableSlotsQuery
{
    public async Task<List<SlotResponse>> ExecuteAsync()
    {
        var availableSlots = await doctorAvailabilityService.GetAvailableSlotsAsync();

        return availableSlots;
    }
}