namespace DoctorAvailability.Models;

internal interface ISlotRepository
{
    Task<List<Slot?>> GetAllSlotsAsync();
    Task<List<Slot?>> GetAvailableSotsAsync();
    Task<Slot?> GetSlotByIdAsync(Guid id);
    Task AddSlotAsync(Slot slot);
    Task SaveChangesAsync();
}