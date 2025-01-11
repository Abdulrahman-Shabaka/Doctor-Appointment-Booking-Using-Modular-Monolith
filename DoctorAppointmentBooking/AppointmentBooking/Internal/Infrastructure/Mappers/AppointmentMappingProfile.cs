﻿using AppointmentBooking.Internal.Domain.Models;
using AppointmentBooking.Public.Requests;
using AppointmentBooking.Public.Responses;

using AutoMapper;

namespace AppointmentBooking.Internal.Infrastructure.Mappers;

internal class AppointmentMappingProfile : Profile
{
    public AppointmentMappingProfile()
    {
        CreateMap<BookAppointmentRequest, Appointment>();
        CreateMap<Appointment, AppointmentResponse>();
    }   
}