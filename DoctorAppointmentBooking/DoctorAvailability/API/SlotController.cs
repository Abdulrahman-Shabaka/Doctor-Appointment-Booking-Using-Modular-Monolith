using AutoMapper;
using DoctorAvailability.Shared.DTOs.Requests;
using DoctorAvailability.Shared.DTOs.Response;
using DoctorAvailability.Shared.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAvailability.API;

[ApiController]
[Route("api/doctor-availabilities")]
public class DoctorAvailabilitiesController(IDoctorAvailabilityService doctorAvailabilityService, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<List<SlotResponse>>> GetAllSlots()
    {
        var slots = await doctorAvailabilityService.GetSlotsAsync();
        return Ok(slots);
    }

    [HttpPost]
    public async Task<IActionResult> AddSlot(AddSlotRequest request)
    {
        await doctorAvailabilityService.AddSlotAsync(request);
        return Ok();
    }
}