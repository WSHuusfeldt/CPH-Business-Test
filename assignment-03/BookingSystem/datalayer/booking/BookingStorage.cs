using BookingSystem.dto;

namespace BookingSystem.datalayer.booking
{
    public interface BookingStorage
    {
        int createBooking(Booking booking);
        List<Booking> GetBookingsForCustomer(int customerId);
        List<Booking> GetBookingsForEmployee(int employeeId);
    }
}