namespace DoctorAvailability.Public.Requests;

public class AddSlotRequest
{
    public DateTime Time { get; set; }
    public Guid DoctorId { get; set; }
    public string DoctorName { get; set; }
    public decimal Cost { get; set; }
}