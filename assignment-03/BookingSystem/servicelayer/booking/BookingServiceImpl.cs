using System;
using BookingSystem.dto;
using BookingSystem.datalayer.booking;
using BookingSystem.servicelayer.customer;

namespace BookingSystem.servicelayer.booking
{
    using BookingSystem.servicelayer.sms;
    public class BookingServiceImpl : BookingService
    {
        private BookingStorage bookingStorage;
        private CustomerService customerService;
        private SmsService smsService;

        public BookingServiceImpl(BookingStorage bookingStorage, CustomerService customerService, SmsService smsService)
        {
            this.bookingStorage = bookingStorage;
            this.customerService = customerService;
            this.smsService = smsService;
        }
        public int createBooking(int customerId, int employeeId, DateTime date, TimeSpan start, TimeSpan end)
        {
            int bookingId = bookingStorage.createBooking(new Booking(0, customerId, employeeId, date, start, end));
            Customer customer = customerService.getCustomerById(customerId);
            smsService.SendConfirmation(new SmsMessage(customer.phoneNumber, "Confirmed"));
            return bookingId;
        }
        public List<Booking> getBookingsForCustomer(int customerId)
        {
            return bookingStorage.GetBookingsForCustomer(customerId);
        }
        public List<Booking> getBookingsForEmployee(int employeeId)
        {
            return bookingStorage.GetBookingsForEmployee(employeeId);
        }
    }
}