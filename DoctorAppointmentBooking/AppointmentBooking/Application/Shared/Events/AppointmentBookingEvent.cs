using SharedKernel.Events;

namespace AppointmentBooking.Application.Shared.Events;

public record AppointmentBookedEvent(
    Guid AppointmentId,
    Guid SlotId,
    Guid PatientId,
    string PatientName,
    DateTime AppointmentTime,
    string DoctorName)
    : IEvent;