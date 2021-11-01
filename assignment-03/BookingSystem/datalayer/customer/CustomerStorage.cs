using BookingSystem.dto;

namespace BookingSystem.datalayer.customer
{
    public interface CustomerStorage
    {
        public Customer getCustomerWithId(int customerId);
        public List<Customer> getCustomers();
        public int createCustomer(CustomerCreation customerToCreate);
    }
}