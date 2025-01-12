using DoctorAvailability.Public.DTOs.Response;

namespace AppointmentBooking.Application.Shared.Interfaces.IQueries;

public interface IAvailableSlotsQuery
{
    Task<List<SlotResponse>> ExecuteAsync();
}