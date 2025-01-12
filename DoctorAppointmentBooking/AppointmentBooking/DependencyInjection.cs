using AppointmentBooking.Internal.Application.UseCases.Commands;
using AppointmentBooking.Internal.Application.UseCases.Query;
using AppointmentBooking.Internal.Domain.Interfaces;
using AppointmentBooking.Internal.Infrastructure;
using AppointmentBooking.Internal.Infrastructure.Repositories;
using AppointmentBooking.Public.Interfaces.ICommands;
using AppointmentBooking.Public.Interfaces.IQueries;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AppointmentBooking;

public static class DependencyInjection
{
    public static IServiceCollection AddAppointmentBookingModule(this IServiceCollection services)
    {
        services.AddScoped<IAppointmentRepository, AppointmentRepository>();

        services.AddScoped<IBookAppointmentCommand, BookAppointmentCommandHandler>();
        services.AddScoped<ICompleteAppointmentCommand, CompleteAppointmentCommand>();
        services.AddScoped<ICancelAppointmentCommand, CancelAppointmentCommand>();

        services.AddScoped<IAvailableSlotsQuery, AvailableSlotsQueryHandler>();

        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        services.AddDbContext<AppointmentDbContext>(options =>
            options.UseInMemoryDatabase("AppointmentInMemoryDb"));

        return services;
    }
}