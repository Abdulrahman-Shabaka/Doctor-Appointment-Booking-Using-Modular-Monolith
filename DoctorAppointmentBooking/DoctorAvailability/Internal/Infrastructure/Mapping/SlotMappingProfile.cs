using AutoMapper;

using DoctorAvailability.Internal.Domain.Slots;
using DoctorAvailability.Public.Requests;
using DoctorAvailability.Public.Response;

namespace DoctorAvailability.Internal.Infrastructure.Mapping;

internal class SlotMappingProfile : Profile
{
    public SlotMappingProfile()
    {
        CreateMap<Slot, SlotResponse>();
        CreateMap<AddSlotRequest, Slot>();
    }
}