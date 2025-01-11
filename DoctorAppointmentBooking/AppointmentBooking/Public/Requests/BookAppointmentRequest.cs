namespace AppointmentBooking.Public.Requests;

public class BookAppointmentRequest
{
    public Guid SlotId { get; set; }
    public Guid PatientId { get; set; }
    public string PatientName { get; set; }
}