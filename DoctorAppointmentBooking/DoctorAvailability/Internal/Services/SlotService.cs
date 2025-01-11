using AutoMapper;

using DoctorAvailability.Internal.Models;
using DoctorAvailability.Public.Interfaces;
using DoctorAvailability.Public.Requests;
using DoctorAvailability.Public.Response;

using static System.Reflection.Metadata.BlobBuilder;

namespace DoctorAvailability.Internal.Services;

internal class DoctorAvailabilityService(ISlotRepository slotRepository, IMapper mapper) : IDoctorAvailabilityService
{
    public async Task<List<SlotResponse>> GetSlotsAsync()
    {
        var slots = await slotRepository.GetAllSlotsAsync();
        return mapper.Map<List<SlotResponse>>(slots);
    }

    public async Task<List<SlotResponse>> GetAvailableSlotsAsync()
    {
        var slots = await slotRepository.GetAvailableSotsAsync();
        return mapper.Map<List<SlotResponse>>(slots);
    }

    public async Task<SlotResponse> GetSlotIfAvailableAsync(Guid id)
    {
        var slot = await FindSlotAsync(id);

        if (slot == null || slot.IsReserved)
            throw new InvalidOperationException("Slot is already reserved or doesn't exist.");

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