using AppointmentBooking.Application.Shared.DTOs.Requests;
using AppointmentBooking.Application.Shared.DTOs.Responses;
using AppointmentBooking.Application.Shared.Interfaces.ICommands;
using AppointmentBooking.Application.Shared.Interfaces.IQueries;
using DoctorAvailability.Public.DTOs.Response;

using Microsoft.AspNetCore.Mvc;

namespace AppointmentBooking.API;

[ApiController]
[Route("api/appointments")]
public class AppointmentController(IBookAppointmentCommand bookAppointmentCommand, IAvailableSlotsQuery availableSlotsQuery) : ControllerBase
{
    [HttpPost("book")]
    public async Task<ActionResult<AppointmentResponse>> BookAppointment([FromBody] BookAppointmentRequest request)
    {
        var appointment = await bookAppointmentCommand.ExecuteAsync(request);
        return Ok(appointment);
    }

    [HttpGet("available-slots")]
    public async Task<ActionResult<List<SlotResponse>>> GetAvailableSlots()
    {
        var availableSlots = await availableSlotsQuery.ExecuteAsync();
        return Ok(availableSlots);
    }
}