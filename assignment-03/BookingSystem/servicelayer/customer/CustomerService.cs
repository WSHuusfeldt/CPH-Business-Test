using BookingSystem.dto;

namespace BookingSystem.servicelayer.customer
{
    public interface CustomerService
    {
        public int createCustomer(string firstName, string lastName, DateTime birthdate);
        public Customer getCustomerById(int id);
        public List<Customer> getCustomersByFirstName(string firstName);
    }
}