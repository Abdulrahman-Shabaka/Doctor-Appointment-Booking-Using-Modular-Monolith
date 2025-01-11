namespace AppointmentConfirmation.Public.Requests;

public class ConfirmationRequest
{
    public Guid AppointmentId { get; }
    public Guid SlotId { get; }
    public Guid PatientId { get; }
    public string PatientName { get; }
    public DateTime AppointmentTime { get; }
    public string DoctorName { get; }
}