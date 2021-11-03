using BookingSystem.dto;
using BookingSystem.datalayer.employee;
using Xunit;
using FakeItEasy;
using System;
using System.Collections.Generic;

namespace BookingSystem.Test.storage
{
    public class EmployeeStorageTest
    {

        [Fact]
        public void createEmployeeTest()
        {
            //Arrage
            EmployeeStorage storage = A.Fake<EmployeeStorage>();
            Employee EmployeeToAdd = new(123, "Willi", "Wombat", DateTime.Now);
            //Act
            int actual = storage.createEmployee(EmployeeToAdd);

            //Assert
            A.CallTo(() => storage.createEmployee(EmployeeToAdd)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void getEmployeeByIdTest()
        {
            //Given
            EmployeeStorage storage = A.Fake<EmployeeStorage>();
            //When
            Employee Employee = storage.getEmployeeById(2);
            //Then
            A.CallTo(() => storage.getEmployeeById(2)).MustHaveHappenedOnceExactly();
        }


    }
}