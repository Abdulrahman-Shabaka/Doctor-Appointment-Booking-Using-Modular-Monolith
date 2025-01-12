using DoctorAvailability.Data;
using DoctorAvailability.Data.Repositories;
using DoctorAvailability.Models;
using DoctorAvailability.Services;
using DoctorAvailability.Shared.Interfaces;

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