using BookingSystem.dto;
using BookingSystem.datalayer.customer;
using Xunit;
using FakeItEasy;
using System;
using System.Collections.Generic;

namespace BookingSystem.Test.storage
{
    public class CustomerStorageTest
    {

        [Fact]
        public void createCustomerTest()
        {
            // Arrage
            CustomerStorage storage = A.Fake<CustomerStorage>();
            CustomerCreation CustomerToAdd = new("Willi", "Wombat");
            //Act
            int actual = storage.createCustomer(CustomerToAdd);

            //Assert
            A.CallTo(() => storage.createCustomer(CustomerToAdd)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void getCustomersTest()
        {
            //Given
            CustomerStorage storage = A.Fake<CustomerStorage>();
            //When
            List<Customer> customers = storage.getCustomers();
            //Then
            A.CallTo(() => storage.getCustomers()).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void GetCustomerWithIdTest()
        {
            //Given
            CustomerStorage storage = A.Fake<CustomerStorage>();
            //When
            Customer customer = storage.getCustomerWithId(1);
            //Then
            A.CallTo(() => storage.getCustomerWithId(1)).MustHaveHappenedOnceExactly();
        }


    }
}