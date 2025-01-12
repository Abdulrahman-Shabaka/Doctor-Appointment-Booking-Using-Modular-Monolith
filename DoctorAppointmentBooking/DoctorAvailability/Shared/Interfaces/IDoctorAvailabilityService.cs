using DoctorAvailability.Shared.DTOs.Requests;
using DoctorAvailability.Shared.DTOs.Response;

namespace DoctorAvailability.Shared.Interfaces;

public interface IDoctorAvailabilityService
{
    Task<List<SlotResponse>> GetSlotsAsync();
    Task<List<SlotResponse>> GetAvailableSlotsAsync();
    Task<SlotResponse> GetSlotIfAvailableAsync(Guid id);
    Task AddSlotAsync(AddSlotRequest request);
    Task ReserveSlotAsync(Guid id);
}