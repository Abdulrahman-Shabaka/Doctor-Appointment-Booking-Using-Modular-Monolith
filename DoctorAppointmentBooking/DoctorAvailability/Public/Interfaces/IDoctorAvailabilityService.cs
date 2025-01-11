using DoctorAvailability.Public.Requests;
using DoctorAvailability.Public.Response;

namespace DoctorAvailability.Public.Interfaces;

public interface IDoctorAvailabilityService
{
    Task<List<SlotResponse>> GetAvailableSlotsAsync();
    Task ValidateSlotAVailabilityAsync(Guid id);
    Task AddSlotAsync(AddSlotRequest request);
    Task ReserveSlotAsync(Guid id);
}