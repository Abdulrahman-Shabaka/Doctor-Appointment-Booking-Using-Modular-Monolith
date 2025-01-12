using DoctorAvailability.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorAvailability.Data.Repositories;

internal class SlotRepository(DoctorAvailabilityDbContext context) : ISlotRepository
{
    public async Task<List<Slot?>> GetAllSlotsAsync()
    {
        return await context.Slots.ToListAsync();
    }

    public async Task<List<Slot?>> GetAvailableSotsAsync()
    {
        return await context.Slots
            .Where(s => !s.IsReserved)
            .ToListAsync();
    }

    public async Task<Slot?> GetSlotByIdAsync(Guid id)
    {
        return await context.Slots.FindAsync(id);
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