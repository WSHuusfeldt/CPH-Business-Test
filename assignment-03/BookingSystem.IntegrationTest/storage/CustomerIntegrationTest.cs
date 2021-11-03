using BookingSystem.dto;
using BookingSystem.datalayer.customer;
using Xunit;
using System;
using System.Collections.Generic;

namespace BookingSystem.IntegrationTest.storage
{
    public class CustomerStorageIntegrationTest
    {
        private string server = "localhost", port = "3307", username = "root", password = "P@ssword123";


        [Fact]
        public void createCustomerTest()
        {
            // Arrage
            CustomerStorageImpl storage = new CustomerStorageImpl(server, port, username, password);
                
            CustomerCreation CustomerToAdd = new("Willi", "Wombat");
            //Act
            int actual = storage.createCustomer(CustomerToAdd);
            Customer customer = storage.getCustomerWithId(actual);
            //Assert
            Assert.Equal(CustomerToAdd.firstname, customer.firstname);
        }

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
            int customerId = 1;
            //When
            Customer customer = storage.getCustomerWithId(customerId);
            //Then
            Assert.Equal(customerId, customer.id);
        }


    }
}