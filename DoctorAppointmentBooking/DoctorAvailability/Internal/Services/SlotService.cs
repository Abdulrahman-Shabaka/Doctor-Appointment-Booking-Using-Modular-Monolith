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

    public async Task<SlotResponse> GetSlotByIdAsync(Guid id)
    {
        var slot = await FindSlotAsync(id);
        return mapper.Map<SlotResponse>(slot);
    }

    public async Task AddSlotAsync(AddSlotRequest request)
    {
        var slot = mapper.Map<Slot>(request);
        await slotRepository.AddSlotAsync(slot);
        await slotRepository.SaveChangesAsync();
    }

    public async Task ReserveSlotAsync(Guid id)
    {
        var slot = await FindSlotAsync(id);
        if (slot != null) slot.IsReserved = true;
        await slotRepository.SaveChangesAsync();
    }

    private async Task<Slot?> FindSlotAsync(Guid id)
    {
        var slot = await slotRepository.GetSlotByIdAsync(id);
        return slot;
    }
}