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

        public override bool Equals(object? obj)
        {
            return obj is Booking booking &&
                   id == booking.id &&
                   customerId == booking.customerId &&
                   employeeId == booking.employeeId &&
                   date == booking.date &&
                   start.Equals(booking.start) &&
                   end.Equals(booking.end);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, customerId, employeeId, date, start, end);
        }
    }
}