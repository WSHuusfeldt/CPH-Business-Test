using BookingSystem.dto;
using BookingSystem.datalayer.employee;
using Xunit;
using System;
using System.Collections.Generic;

namespace BookingSystem.IntegrationTest.storage
{
    public class EmployeeStorageIntegrationTest
    {
        private string server = "localhost", port = "3307", username = "root", password = "P@ssword123";


        [Fact]
        public void createEmployeeTest()
        {
            //Arrage
            EmployeeStorageImpl storage = new EmployeeStorageImpl(server, port, username, password);
            Employee employeeToAdd = new(0, "Willi", "Wombat", new(2021, 02, 02));

            //Act
            int actual = storage.createEmployee(employeeToAdd);
            Employee employeeResult = storage.getEmployeeById(actual);
            Employee expected = new(actual, employeeToAdd.firstName, employeeToAdd.lastName, employeeToAdd.birthday);

            //Assert
            Assert.Equal(expected, employeeResult);
        }

        [Fact]
        public void getEmployeeByIdTest()
        {
            //Given
            EmployeeStorageImpl storage = new EmployeeStorageImpl(server, port, username, password);
            int employeeId = 2;
            //When
            Employee Employee = storage.getEmployeeById(employeeId);
            //Then
            Assert.Equal(employeeId, Employee.id);
        }


    }
}