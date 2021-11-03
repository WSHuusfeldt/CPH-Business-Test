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

        public override bool Equals(object? obj)
        {
            return obj is SmsMessage message &&
                   recipient == message.recipient &&
                   this.message == message.message;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(recipient, message);
        }
    }
}