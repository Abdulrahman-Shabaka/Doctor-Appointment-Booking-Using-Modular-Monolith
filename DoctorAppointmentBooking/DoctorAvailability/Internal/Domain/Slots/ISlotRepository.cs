namespace DoctorAvailability.Internal.Domain.Slots;

internal interface ISlotRepository
{
    Task<List<Slot>> GetAvailableSlotsAsync();
    Task AddSlotAsync(Slot slot);
    Task SaveChangesAsync();
}