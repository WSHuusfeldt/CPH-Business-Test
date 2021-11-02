using BookingSystem.datalayer.employee;
using BookingSystem.dto;
using System;
namespace BookingSystem.servicelayer.employee
{
    public class EmployeeServiceImpl : EmployeeService
    {
        private EmployeeStorage employeeStorage;

        public EmployeeServiceImpl(EmployeeStorage employeeStorage)
        {
            this.employeeStorage = employeeStorage;
        }
        public int createEmployee(Employee employee)
        {
            return employeeStorage.createEmployee(employee);
        }
        public Employee getEmployeeById(int id)
        {
            return employeeStorage.getEmployeeById(id);
        }
    }
}