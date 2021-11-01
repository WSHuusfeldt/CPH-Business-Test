// See https://aka.ms/new-console-template for more information
using BookingSystem.datalayer.customer;
using BookingSystem.dto;

string server = "localhost";
string port = "3307";
string username = "root";
string password = "P@ssword123";

CustomerStorageImpl storage = new CustomerStorageImpl(server, port, username, password);
storage.createCustomer(new CustomerCreation("Andreas", "Vikke"));
var test = storage.getCustomerWithId(5);
Console.WriteLine(test.firstname);