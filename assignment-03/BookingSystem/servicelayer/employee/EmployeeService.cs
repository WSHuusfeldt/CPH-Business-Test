using BookingSystem.dto;
using System;
namespace BookingSystem.servicelayer.employee
{
    public interface EmployeeService
    {
        int createEmployee(Employee employee);
        Employee getEmployeeById(int id);
    }
}