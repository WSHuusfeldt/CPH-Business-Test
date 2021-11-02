using System;
using BookingSystem.dto;
namespace BookingSystem.servicelayer.booking
{
    public interface BookingService
    {
        int createBooking(int customerId, int employeeId, DateTime date, TimeSpan start, TimeSpan end);
        List<Booking> getBookingsForCustomer(int customerId);
        List<Booking> getBookingsForEmployee(int employeeId);
    }
}