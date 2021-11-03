using BookingSystem.datalayer.booking;
using BookingSystem.dto;
using BookingSystem.datalayer.booking;
using sms = BookingSystem.servicelayer.sms;
using FakeItEasy;
using Xunit;
using System;
using System.Collections.Generic;

namespace BookingSystem.Test.storage
{
    public class BookingStorageTest
    {
        private string server = "localhost", port = "3307", username = "root", password = "P@ssword123";


        // [Fact]
        // public void CreateBookingTest()
        // {
        //     //Arrage
        //     BookingStorageImpl storage = new BookingStorageImpl(server, port, username, password);
        //     Booking bookingToAdd = new(88, 4, 2, DateTime.Now, TimeSpan.Zero, new(23, 59, 59));
        //     //Act
        //     int actual = storage.createBooking(bookingToAdd);

        //     //Assert
        //     Assert.NotEqual(-1, actual);
        // }

        [Fact]
        public void GetBookingsForCustomerTest()
        {
            //Given
            BookingStorageImpl storage = new BookingStorageImpl(server, port, username, password);
            //When
            List<Booking> bookings = storage.GetBookingsForCustomer(4);
            //Then
            Assert.NotEmpty(bookings);
        }

        [Fact]
        public void GetBookingsForEmployeeTest()
        {
            //Given
            BookingStorageImpl storage = new BookingStorageImpl(server, port, username, password);

            //When
            List<Booking> bookings = storage.GetBookingsForEmployee(2);
            //Then
            Assert.NotEmpty(bookings);
        }


    }
}