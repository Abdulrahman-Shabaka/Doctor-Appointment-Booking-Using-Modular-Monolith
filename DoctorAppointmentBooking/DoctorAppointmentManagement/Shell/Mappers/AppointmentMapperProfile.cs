using AppointmentBooking.Application.Shared.DTOs.Responses;

using AutoMapper;

using DoctorAppointmentManagement.Core.DTOs;

namespace DoctorAppointmentManagement.Shell.Mappers;

public class AppointmentMapperProfile : Profile
{
    public AppointmentMapperProfile()
    {
        CreateMap<AppointmentResponse, AppointmentDto>();
    }
}