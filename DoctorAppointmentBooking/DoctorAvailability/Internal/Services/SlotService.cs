using AutoMapper;

using DoctorAvailability.Internal.Models;
using DoctorAvailability.Public.Interfaces;
using DoctorAvailability.Public.Requests;
using DoctorAvailability.Public.Response;

namespace DoctorAvailability.Internal.Services;

internal class DoctorAvailabilityService(ISlotRepository slotRepository, IMapper mapper) : IDoctorAvailabilityService
{
    public async Task<List<SlotResponse>> GetAvailableSlotsAsync()
    {
        var slots = await slotRepository.GetAvailableSlotsAsync();
        return mapper.Map<List<SlotResponse>>(slots);
    }

    public async Task AddSlotAsync(AddSlotRequest request)
    {
        var slot = mapper.Map<Slot>(request);
        await slotRepository.AddSlotAsync(slot);
        await slotRepository.SaveChangesAsync();
    }
}