using DoctorAvailability.Internal.Application.Services;
using DoctorAvailability.Internal.Domain.Slots;
using DoctorAvailability.Internal.Infrastructure.Persistence;
using DoctorAvailability.Internal.Infrastructure.Persistence.Repositories;
using DoctorAvailability.Public.Interfaces;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DoctorAvailability;

public static class DependencyInjection
{
    public static IServiceCollection AddDoctorAvailabilityModule(this IServiceCollection services)
    {
        services.AddScoped<ISlotRepository, SlotRepository>();
        services.AddScoped<IDoctorAvailabilityService, DoctorAvailabilityService>();

        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        services.AddDbContext<DoctorAvailabilityDbContext>(options =>
            options.UseInMemoryDatabase("DoctorAvailabilityInMemoryDb"));

        return services;
    }
}