using DoctorAvailability.Public.DTOs.Requests;
using DoctorAvailability.Public.DTOs.Response;

namespace DoctorAvailability.Public.Interfaces;

public interface IDoctorAvailabilityService
{
    Task<List<SlotResponse>> GetSlotsAsync();
    Task<List<SlotResponse>> GetAvailableSlotsAsync();
    Task<SlotResponse> GetSlotIfAvailableAsync(Guid id);
    Task AddSlotAsync(AddSlotRequest request);
    Task ReserveSlotAsync(Guid id);
}