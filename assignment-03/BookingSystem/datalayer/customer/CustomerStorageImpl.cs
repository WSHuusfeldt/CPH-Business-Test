using BookingSystem.dto;
using MySqlConnector;

namespace BookingSystem.datalayer.customer
{
    public class CustomerStorageImpl : CustomerStorage
    {
        private string server, port, username, password;

        public CustomerStorageImpl(string server, string port, string user, string pass)
        {
            this.server = server;
            this.port = port;
            username = user;
            password = pass;
        }
        private MySqlConnection getConnection()
        {
            return new MySqlConnection($"Server={server};port={port};User ID={username};Password={password};Database=customerDb");
        }

        public int createCustomer(CustomerCreation customerToCreate)
        {
            using (var connection = getConnection())
            {
                connection.Open();

                using (var command = new MySqlCommand("insert into Customers(firstname, lastname) values (@firstname, @lastname);", connection))
                {
                    command.Parameters.AddWithValue("@firstname", customerToCreate.firstname);
                    command.Parameters.AddWithValue("@lastname", customerToCreate.lastname);
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                            return reader.GetInt32(1);
                }
            }
            return -1;
        }

        public List<Customer> getCustomers()
        {
            List<Customer> customers = new List<Customer>();
            using (var connection = getConnection())
            {
                connection.Open();

                using (var command = new MySqlCommand("select ID, firstname, lastname, birthdate, phoneNumber from Customers;", connection))
                using (var reader = command.ExecuteReader())
                    while (reader.Read())
                        customers.Add(new Customer(
                            reader.GetInt32("ID"),
                            reader.GetString("firstname"),
                            reader.GetString("lastname"),
                            reader.GetString("birthdate"),
                            reader.GetString("phoneNumber")
                        ));
            }
            return customers;
        }

        public Customer getCustomerWithId(int customerId)
        {
            using (var connection = getConnection())
            {
                connection.Open();

                using (var command = new MySqlCommand("select ID, firstname, lastname, birthdate, phoneNumber from Customers where id=@id;", connection))
                {
                    command.Parameters.AddWithValue("@id", customerId);
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                            return new Customer(
                                reader.GetInt32("ID"),
                                reader.GetString("firstname"),
                                reader.GetString("lastname"),
                                reader.GetString("birthdate"),
                                reader.GetString("phoneNumber")
                            );
                }
            }
            return null;
        }
    }
}