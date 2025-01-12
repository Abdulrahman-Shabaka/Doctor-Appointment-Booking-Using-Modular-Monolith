using DoctorAppointmentManagement.Core.DTOs;
using DoctorAppointmentManagement.Core.InputPorts;

using Microsoft.AspNetCore.Mvc;

namespace DoctorAppointmentManagement.Shell.API;

[ApiController]
[Route("api/doctor-appointment-management")]
public class DoctorAppointmentManagementController(IDoctorAppointmentManagementService doctorAppointmentManagementService) : ControllerBase
{
    [HttpGet("upcoming-appointment")]
    public async Task<ActionResult<List<AppointmentDto>>> GetUpcomingAppointments()
    {
        var appointments = await doctorAppointmentManagementService.GetUpcomingAppointmentsAsync();
        return Ok(appointments);
    }

    [HttpPost("complete-appointment")]
    public async Task<ActionResult> CompleteAppointments([FromBody] CompleteAppointmentDto request)
    {
        await doctorAppointmentManagementService.CompleteAppointmentAsync(request);
        return Ok();
    }

    [HttpPost("cancel-appointment")]
    public async Task<ActionResult> CancelAppointments([FromBody] CancelAppointmentDto request)
    {
        await doctorAppointmentManagementService.CancelAppointmentAsync(request);
        return Ok();
    }
}