using AppointmentBooking.Public.DTOs.Requests;
using AppointmentBooking.Public.DTOs.Responses;
using AppointmentBooking.Public.Interfaces.ICommands;
using AppointmentBooking.Public.Interfaces.IQueries;
using DoctorAvailability.Public.DTOs.Response;

using Microsoft.AspNetCore.Mvc;

namespace AppointmentBooking.Public.API;

[ApiController]
[Route("api/appointments")]
public class AppointmentController(IBookAppointmentCommand bookAppointmentCommand, IAvailableSlotsQuery availableSlotsQuery) : ControllerBase
{
    [HttpPost("book")]
    public async Task<ActionResult<AppointmentResponse>> BookAppointment([FromBody] BookAppointmentRequest request)
    {
        var appointment = await bookAppointmentCommand.ExecuteAsync(request);
        return Ok (appointment);
    }

    [HttpGet("available-slots")]
    public async Task<ActionResult<List<SlotResponse>>> GetAvailableSlots()
    {
        var availableSlots = await availableSlotsQuery.ExecuteAsync();
        return Ok(availableSlots);
    }
}