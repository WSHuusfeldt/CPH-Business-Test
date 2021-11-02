using BookingSystem.datalayer.booking;
using BookingSystem.dto;
using BookingSystem.servicelayer.booking;
using BookingSystem.servicelayer.customer;
using sms = BookingSystem.servicelayer.sms;
using FakeItEasy;
using Xunit;
using System;

namespace BookingSystem.Test.servicelayer
{
    public class BookingTest
    {

        [Fact]
        public void CreateBookingSmsCallTest()
        {
            //Arrage
            BookingStorage storage = A.Fake<BookingStorage>();
            sms.SmsService smsService = A.Fake<sms.SmsService>();
            CustomerService customerService = A.Fake<CustomerService>();

            BookingService service = new BookingServiceImpl(storage, customerService, smsService);

            //Act
            service.createBooking(1, 1, new DateTime(2010, 4, 4), TimeSpan.Zero, new TimeSpan(12, 0, 0));

            //Assert
            A.CallTo(() => smsService.SendConfirmation(A<SmsMessage>.Ignored)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void CreateBookingStorageCallTest()
        {
            //Arrage
            BookingStorage storage = A.Fake<BookingStorage>();
            sms.SmsService smsService = A.Fake<sms.SmsService>();
            CustomerService customerService = A.Fake<CustomerService>();

            BookingService service = new BookingServiceImpl(storage, customerService, smsService);

            //Act
            service.createBooking(1, 1, new DateTime(2010, 4, 4), TimeSpan.Zero, new TimeSpan(12, 0, 0));

            //Assert
            A.CallTo(() => storage.createBooking(A<Booking>.Ignored)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void getBookingsForCustomerStorageCallTest()
        {
            //Given
            BookingStorage storage = A.Fake<BookingStorage>();
            sms.SmsService smsService = A.Fake<sms.SmsService>();
            CustomerService customerService = A.Fake<CustomerService>();

            BookingService service = new BookingServiceImpl(storage, customerService, smsService);
            //When
            service.getBookingsForCustomer(1);

            //Then
            A.CallTo(() => storage.GetBookingsForCustomer(A<int>.Ignored)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void getBookingsForEmployeeStorageCallTest()
        {
            //Given
            BookingStorage storage = A.Fake<BookingStorage>();
            sms.SmsService smsService = A.Fake<sms.SmsService>();
            CustomerService customerService = A.Fake<CustomerService>();

            BookingService service = new BookingServiceImpl(storage, customerService, smsService);
            //When
            service.getBookingsForEmployee(1);


            //Then
            A.CallTo(() => storage.GetBookingsForEmployee(A<int>.Ignored)).MustHaveHappenedOnceExactly();
        }
    }
}