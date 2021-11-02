using BookingSystem.dto;
namespace BookingSystem.servicelayer.sms
{
    public interface SmsService
    {
        bool SendConfirmation(SmsMessage message);
    }
}