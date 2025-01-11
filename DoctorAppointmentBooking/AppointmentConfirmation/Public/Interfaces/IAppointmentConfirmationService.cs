using AppointmentConfirmation.Public.Requests;

namespace AppointmentConfirmation.Public.Interfaces;

public interface IAppointmentConfirmationService
{
    void ConfirmAppointment(ConfirmationRequest confirmationRequest);
}