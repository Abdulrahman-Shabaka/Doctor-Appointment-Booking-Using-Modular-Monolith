using DoctorAvailability.Internal.Domain.Slots;

using Microsoft.EntityFrameworkCore;

namespace DoctorAvailability.Internal.Infrastructure.Persistence.Repositories;

internal class SlotRepository(DoctorAvailabilityDbContext context) : ISlotRepository
{
    public async Task<List<Slot>> GetAvailableSlotsAsync()
    {
        return await context.Slots
            .Where(s => !s.IsReserved)
            .ToListAsync();
    }

    public async Task AddSlotAsync(Slot slot)
    {
        await context.AddAsync(slot);
    }

    public async Task SaveChangesAsync()
    {
        await context.SaveChangesAsync();
    }
}