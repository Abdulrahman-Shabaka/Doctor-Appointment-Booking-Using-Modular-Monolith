using AppointmentConfirmation.Internal.Services;
using AppointmentConfirmation.Public.Interfaces;

using Microsoft.Extensions.DependencyInjection;

namespace AppointmentConfirmation;

public static class DependencyInjection
{
    public static IServiceCollection AddAppointConfirmationModule(this IServiceCollection services)
    {
        services.AddScoped<IAppointmentConfirmationService, AppointmentConfirmationService>();

        return services;
    }
}