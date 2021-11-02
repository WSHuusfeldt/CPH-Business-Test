using BookingSystem.dto;
using System;

namespace BookingSystem.datalayer.employee
{
    public interface EmployeeStorage
    {
        int createEmployee(Employee employee);
        Employee getEmployeeById(int employeeId);
    }
}