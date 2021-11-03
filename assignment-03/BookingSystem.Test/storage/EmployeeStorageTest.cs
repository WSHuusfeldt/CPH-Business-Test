using BookingSystem.dto;
using BookingSystem.datalayer.employee;
using Xunit;
using System;
using System.Collections.Generic;

namespace BookingSystem.Test.storage
{
    public class EmployeeStorageTest
    {
        private string server = "localhost", port = "3307", username = "root", password = "P@ssword123";


        // [Fact]
        // public void createEmployeeTest()
        // {
        //     //Arrage
        //     EmployeeStorageImpl storage = new EmployeeStorageImpl(server, port, username, password);
        //     Employee EmployeeToAdd = new(123, "Willi", "Wombat", DateTime.Now);
        //     //Act
        //     int actual = storage.createEmployee(EmployeeToAdd);

        //     //Assert
        //     Assert.NotEqual(-1, actual);
        // }

        [Fact]
        public void getEmployeeByIdTest()
        {
            //Given
            EmployeeStorageImpl storage = new EmployeeStorageImpl(server, port, username, password);
            //When
            Employee Employee = storage.getEmployeeById(2);
            //Then
            Assert.Equal(1, Employee.id);
        }


    }
}