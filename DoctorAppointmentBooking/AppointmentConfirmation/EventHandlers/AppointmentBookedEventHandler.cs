using AppointmentBooking.Application.Shared.Events;

namespace AppointmentConfirmation.EventHandlers;

internal class AppointmentBookedEventHandler
{
    public void Handle(AppointmentBookedEvent @event)
    {
        Console.WriteLine(
            $"Notification to Patient: Dear {@event.PatientName}," +
            $" your appointment with Dr. {@event.DoctorName}" +
            $" is confirmed at {@event.AppointmentTime}.");

        Console.WriteLine(
            $"Notification to Doctor: Dr. {@event.DoctorName}," +
            $" a new appointment has been booked by {@event.PatientName} " +
            $"at {@event.AppointmentTime}.");
    }
}