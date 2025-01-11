namespace DoctorAvailability.Internal.Models;

internal interface ISlotRepository
{
    Task<List<Slot>> GetAvailableSlotsAsync();
    Task<Slot?> GetSlotByIdAsync(Guid id);
    Task AddSlotAsync(Slot slot);
    Task SaveChangesAsync();
}