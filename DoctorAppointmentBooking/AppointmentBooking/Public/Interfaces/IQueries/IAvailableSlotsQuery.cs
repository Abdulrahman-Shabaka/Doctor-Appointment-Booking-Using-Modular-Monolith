using DoctorAvailability.Public.DTOs.Response;

namespace AppointmentBooking.Public.Interfaces.IQueries;

public interface IAvailableSlotsQuery
{
    Task<List<SlotResponse>> ExecuteAsync();
}