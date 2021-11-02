using BookingSystem.dto;

namespace BookingSystem.datalayer.customer
{
    public interface CustomerStorage
    {
        Customer getCustomerWithId(int customerId);
        List<Customer> getCustomers();
        int createCustomer(CustomerCreation customerToCreate);
    }
}