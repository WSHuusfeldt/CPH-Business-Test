using BookingSystem.datalayer.booking;
using BookingSystem.dto;
using FakeItEasy;
using Xunit;
using System;
using System.Collections.Generic;

namespace BookingSystem.Test.storage
{
    public class BookingStorageTest
    {

        [Fact]
        public void CreateBookingTest()
        {
            //Arrage
            BookingStorage storage = A.Fake<BookingStorage>();
            Booking bookingToAdd = new(88, 4, 2, DateTime.Now, TimeSpan.Zero, new(23, 59, 59));
            //Act
            int actual = storage.createBooking(bookingToAdd);

            //Assert
            A.CallTo(() => storage.createBooking(bookingToAdd)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void GetBookingsForCustomerTest()
        {
            //Given
            BookingStorage storage = A.Fake<BookingStorage>();
            //When
            List<Booking> bookings = storage.GetBookingsForCustomer(4);
            //Then
            A.CallTo(() => storage.GetBookingsForCustomer(4)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void GetBookingsForEmployeeTest()
        {
            //Given
            BookingStorage storage = A.Fake<BookingStorage>();

            //When
            List<Booking> bookings = storage.GetBookingsForEmployee(2);
            //Then
            A.CallTo(() => storage.GetBookingsForEmployee(2)).MustHaveHappenedOnceExactly();
        }

    }
}