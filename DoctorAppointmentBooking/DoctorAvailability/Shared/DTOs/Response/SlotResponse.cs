namespace DoctorAvailability.Shared.DTOs.Response;

public class SlotResponse
{
    public Guid Id { get; set; }
    public DateTime Time { get; set; }
    public string DoctorName { get; set; }
    public bool IsReserved { get; set; }
    public decimal Cost { get; set; }
}