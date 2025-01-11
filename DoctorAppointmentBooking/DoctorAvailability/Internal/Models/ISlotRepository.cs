namespace DoctorAvailability.Internal.Models;

internal interface ISlotRepository
{
    Task<List<Slot>> GetAvailableSlotsAsync();
    Task AddSlotAsync(Slot slot);
    Task SaveChangesAsync();
}