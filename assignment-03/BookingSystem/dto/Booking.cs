namespace BookingSystem.dto
{
    public class Booking
    {
        public int id { get; private set; }
        public int customerId { get; private set; }
        public int employeeId { get; private set; }
        public DateTime date { get; private set; }
        public TimeSpan start { get; private set; }
        public TimeSpan end { get; private set; }

        public Booking(int id, int customerId, int employeeId, DateTime date, TimeSpan start, TimeSpan end)
        {
            this.id = id;
            this.customerId = customerId;
            this.employeeId = employeeId;
            this.date = date;
            this.start = start;
            this.end = end;
        }
    }
}