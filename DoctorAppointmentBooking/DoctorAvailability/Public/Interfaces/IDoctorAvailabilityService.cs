using DoctorAvailability.Public.Requests;
using DoctorAvailability.Public.Response;

namespace DoctorAvailability.Public.Interfaces;

public interface IDoctorAvailabilityService
{
    Task<List<SlotResponse>> GetAvailableSlotsAsync();
    Task<SlotResponse> GetSlotByIdAsync(Guid id);
    Task AddSlotAsync(AddSlotRequest request);
}