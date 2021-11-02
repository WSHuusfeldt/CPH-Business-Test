using BookingSystem.dto;
using System;
namespace BookingSystem.servicelayer.customer
{
    public interface CustomerService
    {
        int createCustomer(string firstName, string lastName, DateTime birthdate);
        Customer getCustomerById(int id);
        List<Customer> getCustomersByFirstName(string firstName);
    }
}