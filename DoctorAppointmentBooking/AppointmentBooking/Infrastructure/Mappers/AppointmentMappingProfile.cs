using AppointmentBooking.Application.Shared.DTOs.Requests;
using AppointmentBooking.Application.Shared.DTOs.Responses;
using AppointmentBooking.Domain.Models;
using AutoMapper;

namespace AppointmentBooking.Infrastructure.Mappers;

internal class AppointmentMappingProfile : Profile
{
    public AppointmentMappingProfile()
    {
        CreateMap<BookAppointmentRequest, Appointment>();
        CreateMap<Appointment, AppointmentResponse>();
    }
}