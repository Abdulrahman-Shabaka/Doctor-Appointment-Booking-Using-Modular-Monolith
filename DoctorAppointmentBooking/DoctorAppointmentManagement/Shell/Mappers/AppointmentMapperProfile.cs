using AppointmentBooking.Application.Shared.DTOs.Requests;
using AppointmentBooking.Application.Shared.DTOs.Responses;

using AutoMapper;

using DoctorAppointmentManagement.Core.DTOs;

namespace DoctorAppointmentManagement.Shell.Mappers;

internal class AppointmentMapperProfile : Profile
{
    public AppointmentMapperProfile()
    {
        CreateMap<AppointmentResponse, AppointmentDto>();
        CreateMap<CompleteAppointmentDto, CompleteAppointmentRequest>();
        CreateMap<CancelAppointmentDto, CancelAppointmentRequest>();
    }
}