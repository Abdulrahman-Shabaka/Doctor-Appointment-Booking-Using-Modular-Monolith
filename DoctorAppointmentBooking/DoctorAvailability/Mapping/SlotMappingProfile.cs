using AutoMapper;
using DoctorAvailability.Models;
using DoctorAvailability.Shared.DTOs.Requests;
using DoctorAvailability.Shared.DTOs.Response;

namespace DoctorAvailability.Mapping;

internal class SlotMappingProfile : Profile
{
    public SlotMappingProfile()
    {
        CreateMap<Slot, SlotResponse>();
        CreateMap<AddSlotRequest, Slot>();
    }
}