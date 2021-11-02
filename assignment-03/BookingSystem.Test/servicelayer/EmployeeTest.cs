using BookingSystem.datalayer.employee;
using BookingSystem.servicelayer.employee;
using BookingSystem.dto;
using FakeItEasy;
using Xunit;
using System;

namespace BookingSystem.Test.servicelayer
{
    public class EmployeeTest
    {
        [Fact]
        public void CreateEmployeeCallTest()
        {
            // Arrange
            EmployeeStorage storage = A.Fake<EmployeeStorage>();
            EmployeeService service = new EmployeeServiceImpl(storage);
            Employee employee = new Employee(0, "Goldman", "Sax", DateTime.Today);

            // Act
            service.createEmployee(employee);

            // Assert
            A.CallTo(() => storage.createEmployee(A<Employee>.Ignored)).MustHaveHappenedOnceExactly();
        }

        [Fact]
        public void getEmployeeByIdCallTest()
        {
            // Arrange
            EmployeeStorage storage = A.Fake<EmployeeStorage>();
            EmployeeService service = new EmployeeServiceImpl(storage);
            int employeeId = 1;

            // Act
            service.getEmployeeById(employeeId);

            // Assert
            A.CallTo(() => storage.getEmployeeById(A<int>.Ignored)).MustHaveHappenedOnceExactly();
        }
    }
}