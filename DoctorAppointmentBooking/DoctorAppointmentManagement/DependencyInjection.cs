using DoctorAppointmentManagement.Core.InputPorts;
using DoctorAppointmentManagement.Core.OutputPorts;
using DoctorAppointmentManagement.Core.Services;
using DoctorAppointmentManagement.Shell.Services;

using Microsoft.Extensions.DependencyInjection;

namespace DoctorAppointmentManagement;

public static class DependencyInjection
{
    public static IServiceCollection AddDoctorAppointmentManagementModule(this IServiceCollection services)
    {
        services.AddScoped<IDoctorAppointmentManagementService, DoctorAppointmentManagementService>();
        services.AddScoped<IAppointmentService, AppointmentService>();

        return services;
    }
}