namespace BookingSystem.dto
{
    public class SmsMessage
    {
        public string recipient { get; private set; }
        public string message { get; private set; }

        public SmsMessage(string recipient, string message)
        {
            this.recipient = recipient;
            this.message = message;
        }
    }
}