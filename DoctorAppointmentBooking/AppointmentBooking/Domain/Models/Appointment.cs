using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AppointmentBooking.Domain.Models;

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

    public void Complete()
    {
        if(State is AppointmentState.Canceled)
            throw new InvalidOperationException("Cannot complete a cancelled appointment.");

        State = AppointmentState.Completed;
    }

    public void Cancel() => State = AppointmentState.Canceled;
}