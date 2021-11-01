using BookingSystem.dto;

namespace BookingSystem.servicelayer.customer
{
    public interface SmsService
    {
        public bool sendSms(SmsMessage message);
    }
}