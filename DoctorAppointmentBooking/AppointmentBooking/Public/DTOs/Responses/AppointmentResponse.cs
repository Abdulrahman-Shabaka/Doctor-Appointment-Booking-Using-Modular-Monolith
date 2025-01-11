namespace AppointmentBooking.Public.DTOs.Responses;

public class AppointmentResponse
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid SlotId { get; set; }
    public Guid PatientId { get; set; }
    public string PatientName { get; set; }
    public DateTime ReservedAt { get; set; }
}