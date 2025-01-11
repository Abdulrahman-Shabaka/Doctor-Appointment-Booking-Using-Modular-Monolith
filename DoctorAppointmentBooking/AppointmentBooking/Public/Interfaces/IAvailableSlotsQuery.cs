using DoctorAvailability.Public.Response;

namespace AppointmentBooking.Public.Interfaces;

public interface IAvailableSlotsQuery
{
    Task<List<SlotResponse>> ExecuteAsync();
}