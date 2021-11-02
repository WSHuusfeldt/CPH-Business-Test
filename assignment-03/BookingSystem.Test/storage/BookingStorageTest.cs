using BookingSystem.datalayer.booking;
using BookingSystem.dto;
using BookingSystem.servicelayer.booking;
using BookingSystem.servicelayer.customer;
using sms = BookingSystem.servicelayer.sms;
using FakeItEasy;
using Xunit;
using System;

namespace BookingSystem.Test.storage
{
    public class BookingStorageTest
    {
        private string server = "localhost", port = "3307", username = "root", password = "P@ssword123";


        [Fact]
        public void CreateBookingTest()
        {
            //Arrage
            BookingStorageImpl storage = new BookingStorageImpl(server, port, username, password);
            Booking bookingToAdd = new(88, 4, 2, DateTime.Now, TimeSpan.Zero, new(23, 59, 59));
            int expected = bookingToAdd.id;
            //Act
            int actual = storage.createBooking(bookingToAdd);

            //Assert
            Assert.Equal(expected, actual);
        }


    }
}