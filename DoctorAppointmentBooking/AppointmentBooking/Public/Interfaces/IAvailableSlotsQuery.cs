using DoctorAvailability.Public.DTOs.Response;

namespace AppointmentBooking.Public.Interfaces;

public interface IAvailableSlotsQuery
{
    Task<List<SlotResponse>> ExecuteAsync();
}