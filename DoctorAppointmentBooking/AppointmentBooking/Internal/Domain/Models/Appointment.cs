using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AppointmentBooking.Internal.Domain.Models;

internal class Appointment
{
    private Appointment()
    {
        State = AppointmentState.New;
    }
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid SlotId { get; set; }
    public Guid PatientId { get; set; }
    public string PatientName { get; set; }
    public AppointmentState State { get; set; }
    public DateTime ReservedAt { get; set; }

    public void Complete() => State = AppointmentState.Completed;
    public void Cancel() => State = AppointmentState.Canceled;
}

internal enum AppointmentState
{
    New = 1,
    Completed = 2,
    Canceled = 3,
}