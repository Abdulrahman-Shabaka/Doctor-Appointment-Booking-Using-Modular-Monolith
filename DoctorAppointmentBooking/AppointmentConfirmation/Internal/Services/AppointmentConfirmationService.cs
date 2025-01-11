using AppointmentConfirmation.Public.Interfaces;
using AppointmentConfirmation.Public.Requests;

namespace AppointmentConfirmation.Internal.Services;

internal class AppointmentConfirmationService : IAppointmentConfirmationService
{
    public void ConfirmAppointment(ConfirmationRequest confirmationRequest)
    {
        Console.WriteLine(
            $"Notification to Patient: Dear {confirmationRequest.PatientName}," +
            $" your appointment with Dr. {confirmationRequest.DoctorName}" +
            $" is confirmed at {confirmationRequest.AppointmentTime}.");

        Console.WriteLine(
            $"Notification to Doctor: Dr. {confirmationRequest.DoctorName}," +
            $" a new appointment has been booked by {confirmationRequest.PatientName} " +
            $"at {confirmationRequest.AppointmentTime}.");
    }
}