using BookingSystem.dto;
using BookingSystem.datalayer.customer;
using Xunit;
using System;
using System.Collections.Generic;

namespace BookingSystem.Test.storage
{
    public class CustomerStorageTest
    {
        private string server = "localhost", port = "3307", username = "root", password = "P@ssword123";


        // [Fact]
        // public void createCustomerTest()
        // {
        //     // Arrage
        //     CustomerStorageImpl storage = new CustomerStorageImpl(server, port, username, password);
                //SKAL GENOVERVEJES
                //giver fejl i test, siden der ikke er birthday eller tlf nummer på og den
                //prøver at trække lortet ud.
        //     CustomerCreation CustomerToAdd = new("Willi", "Wombat");
        //     //Act
        //     int actual = storage.createCustomer(CustomerToAdd);

        //     //Assert
        //     Assert.NotEqual(-1, actual);
        // }

        [Fact]
        public void getCustomersTest()
        {
            //Given
            CustomerStorageImpl storage = new CustomerStorageImpl(server, port, username, password);
            //When
            List<Customer> customers = storage.getCustomers();
            //Then
            Assert.NotEmpty(customers);
        }

        [Fact]
        public void GetCustomerWithIdTest()
        {
            //Given
            CustomerStorageImpl storage = new CustomerStorageImpl(server, port, username, password);
            //When
            Customer customer = storage.getCustomerWithId(1);
            //Then
            Assert.Equal(1, customer.id);
        }


    }
}