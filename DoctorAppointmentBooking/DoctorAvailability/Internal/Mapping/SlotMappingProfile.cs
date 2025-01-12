using AutoMapper;

using DoctorAvailability.Internal.Models;
using DoctorAvailability.Public.DTOs.Requests;
using DoctorAvailability.Public.DTOs.Response;

namespace DoctorAvailability.Internal.Mapping;

internal class SlotMappingProfile : Profile
{
    public SlotMappingProfile()
    {
        CreateMap<Slot, SlotResponse>();
        CreateMap<AddSlotRequest, Slot>();
    }
}