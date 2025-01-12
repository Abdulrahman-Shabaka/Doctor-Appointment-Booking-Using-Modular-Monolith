using AppointmentBooking.Application.Shared.Interfaces.ICommands;
using AppointmentBooking.Application.Shared.Interfaces.IQueries;
using AppointmentBooking.Application.UseCases.Commands;
using AppointmentBooking.Application.UseCases.Query;
using AppointmentBooking.Domain.Interfaces;
using AppointmentBooking.Infrastructure;
using AppointmentBooking.Infrastructure.Repositories;
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