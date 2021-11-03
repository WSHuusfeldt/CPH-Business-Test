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

                using (var command = new MySqlCommand("insert into Employees(firstname, lastname, birthdate) values (@firstname, @lastname, @birthdate); SELECT last_insert_id()", connection))
                {
                    command.Parameters.AddWithValue("@firstname", employee.firstName);
                    command.Parameters.AddWithValue("@lastname", employee.lastName);
                    command.Parameters.AddWithValue("@birthdate", employee.birthday);
                    return (int)(ulong)command.ExecuteScalar();
                }
            }
        }
        public Employee getEmployeeById(int employeeId)
        {
            using (var connection = getConnection())
            {
                connection.Open();

                using (var command = new MySqlCommand("SELECT ID, firstname, lastname, birthdate FROM Employees WHERE ID=@ID;", connection)){
                    command.Parameters.AddWithValue("@ID", employeeId);
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                            return new Employee(
                                reader.GetInt32("ID"),
                                reader.GetString("firstname"),
                                reader.GetString("lastname"),
                                reader.GetDateTime("birthdate")
                            );
                }
            }
            return null;
        }

    }
}