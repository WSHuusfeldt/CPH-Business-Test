using BookingSystem.dto;
using MySqlConnector;

namespace BookingSystem.datalayer.employee
{
    public class EmployeeStorageImpl : EmployeeStorage
    {

        private string server, port, username, password;

        public EmployeeStorageImpl(string server, string port, string user, string pass)
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

        public int createEmployee(Employee employee)
        {
            using (var connection = getConnection())
            {
                connection.Open();

                using (var command = new MySqlCommand("insert into Employees(firstname, lastname) values (@firstname, @lastname);", connection))
                {
                    command.Parameters.AddWithValue("@firstname", employee.firstName);
                    command.Parameters.AddWithValue("@lastname", employee.lastName);
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                            return reader.GetInt32(1);
                }
            }
            return -1;
        }
        public Employee getEmployeeById(int employeeId)
        {
            using (var connection = getConnection())
            {
                connection.Open();

                using (var command = new MySqlCommand("select ID, firstname, lastname, birthdate from Employees;", connection))
                using (var reader = command.ExecuteReader())
                    while (reader.Read())
                        return new Employee(
                            reader.GetInt32("ID"),
                            reader.GetString("firstname"),
                            reader.GetString("lastname"),
                            DateTime.Parse(reader.GetString("birthdate"))
                        );
            }
            return null;
        }

    }
}