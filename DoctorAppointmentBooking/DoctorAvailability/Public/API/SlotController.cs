using AutoMapper;

using DoctorAvailability.Public.Interfaces;
using DoctorAvailability.Public.Requests;
using DoctorAvailability.Public.Response;

using Microsoft.AspNetCore.Mvc;

namespace DoctorAvailability.Public.API;

[ApiController]
[Route("api/doctor-availabilities")]
public class DoctorAvailabilitiesController(IDoctorAvailabilityService doctorAvailabilityService, IMapper mapper) : ControllerBase
{
    [HttpGet("available")]
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