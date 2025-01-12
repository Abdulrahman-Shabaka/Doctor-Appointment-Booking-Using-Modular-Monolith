using AppointmentBooking.Application.Shared.Events;
using AppointmentConfirmation.Internal.EventHandlers;

using Microsoft.Extensions.DependencyInjection;

using SharedKernel.Events;

namespace AppointmentConfirmation;

public static class DependencyInjection
{
    public static IServiceCollection AddAppointConfirmationModule(this IServiceCollection services)
    {
        var eventDispatcher = new EventDispatcher();

        eventDispatcher.Register<AppointmentBookedEvent>(new AppointmentBookedEventHandler().Handle);

        services.AddSingleton(eventDispatcher);

        return services;
    }
}