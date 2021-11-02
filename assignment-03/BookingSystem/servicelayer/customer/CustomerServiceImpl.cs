using BookingSystem.datalayer.customer;
using BookingSystem.dto;
using System;
namespace BookingSystem.servicelayer.customer
{
    public class CustomerServiceImpl : CustomerService
    {
        private CustomerStorage customerStorage;

        public CustomerServiceImpl(CustomerStorage customerStorage)
        {
            this.customerStorage = customerStorage;
        }

        public int createCustomer(string firstName, string lastName, DateTime birthdate)
        {
            return customerStorage.createCustomer(new CustomerCreation(firstName, lastName));
        }

        public Customer getCustomerById(int id)
        {
            return customerStorage.getCustomerWithId(id);
        }

        public List<Customer> getCustomersByFirstName(string firstName)
        {
            throw new NotImplementedException();
        }
    }
}