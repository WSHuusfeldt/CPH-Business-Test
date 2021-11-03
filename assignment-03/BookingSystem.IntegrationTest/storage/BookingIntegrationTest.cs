using BookingSystem.datalayer.booking;
using BookingSystem.dto;
using System;
using System.Collections.Generic;
using Xunit;

namespace BookingSystem.IntegrationTest.storage
{
    public class BookingStorageIntegrationTest
    {
        private string server = "localhost", port = "3307", username = "root", password = "P@ssword123";


        [Fact]
        public void CreateBookingIntegrationTest()
        {
            //Arrage
            Booking bookingToAdd = new(0, 4, 2, new(2021, 10, 29), new(20, 30, 00), new(22, 30, 00));
            BookingStorageImpl storage = new BookingStorageImpl(server, port, username, password);
            //Act
            int actualId = storage.createBooking(bookingToAdd);
            Booking bookingResult = storage.GetBooking(actualId);

            //Assert
            Booking expected = new(actualId, bookingToAdd.customerId, bookingToAdd.employeeId, bookingToAdd.date, bookingToAdd.start, bookingToAdd.end);
            Assert.Equal(expected, bookingResult);
        }

        [Fact]
        public void GetBookingsForCustomerIntegrationTest()
        {
            //Given
            BookingStorageImpl storage = new BookingStorageImpl(server, port, username, password);
            int customerId = 4;
            //When
            List<Booking> bookings = storage.GetBookingsForCustomer(customerId);

            //Then
            Assert.NotEmpty(bookings);
            foreach(Booking b in bookings)
                Assert.True(b.customerId == customerId);
        }

        [Fact]
        public void GetBookingsForEmployeeIntegrationTest()
        {
            //Given
            BookingStorageImpl storage = new BookingStorageImpl(server, port, username, password);
            int employeeId = 2;
            //When
            List<Booking> bookings = storage.GetBookingsForEmployee(employeeId);
            //Then
            Assert.NotEmpty(bookings);
            foreach(Booking b in bookings)
                Assert.True(b.employeeId == employeeId);
        }


    }
}