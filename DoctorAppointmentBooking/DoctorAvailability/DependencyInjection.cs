using DoctorAvailability.Internal.Data;
using DoctorAvailability.Internal.Data.Repositories;
using DoctorAvailability.Internal.Models;
using DoctorAvailability.Internal.Services;
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