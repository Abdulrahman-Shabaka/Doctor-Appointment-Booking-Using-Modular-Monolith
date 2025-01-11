using AutoMapper;

using DoctorAvailability.Internal.Models;
using DoctorAvailability.Public.Requests;
using DoctorAvailability.Public.Response;

namespace DoctorAvailability.Internal.Mapping;

internal class SlotMappingProfile : Profile
{
    public SlotMappingProfile()
    {
        CreateMap<Slot, SlotResponse>();
        CreateMap<AddSlotRequest, Slot>();
    }
}