using BookingSystem.datalayer.customer;
using BookingSystem.servicelayer.customer;
using FakeItEasy;
using Xunit;

namespace BookingSystem.Test.servicelayer;

public class CustomerTest
{

    [Fact]
    public void GetCustomerById_StorageIsUsed_ICustomerStorageIsCalledOnce()
    {
        //Arrage
        CustomerStorage storage = A.Fake<CustomerStorage>();
        CustomerService service = new CustomerServiceImpl(storage);
        int customerId = 1;

        //Act
        service.getCustomerById(customerId);

        //Assert
        A.CallTo(() => storage.getCustomerWithId(A<int>.Ignored)).MustHaveHappenedOnceExactly();
    }

    // [Fact]
    // public void GetCustomersByFirstName_StorageIsUsed_ICustomerStorageIsCalledOnce()
    // {
    //     //Arrage
    //     CustomerStorage storage = A.Fake<CustomerStorage>();
    //     CustomerService service = new CustomerServiceImpl(storage);
    //     string firstname = A.Dummy<string>();

    //     //Act
    //     service.getCustomersByFirstName(firstname);

    //     //Assert
    //     A.CallTo(() => storage.getCustomers()).MustHaveHappenedOnceExactly();
    // }
}