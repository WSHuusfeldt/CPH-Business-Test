using BookingSystem.dto;
using MySqlConnector;

namespace BookingSystem.datalayer.booking
{
    public class BookingStorageImpl : BookingStorage
    {
        private string server, port, username, password;

        public BookingStorageImpl(string server, string port, string user, string pass)
        {
            this.server = server;
            this.port = port;
            username = user;
            password = pass;
        }
        private MySqlConnection getConnection()
        {
            return new MySqlConnection($"Server={server};port={port};UID={username};Password={password};Database=customerDb");
        }

        public int createBooking(Booking booking)
        {
            using (var connection = getConnection())
            {
                connection.Open();
                var cmd = new MySqlCommand("set net_write_timeout=999; set net_read_timeout=999;", connection);
                cmd.ExecuteNonQuery();
                using (var command = new MySqlCommand("INSERT INTO Bookings (customerId, employeeId, date, start, end) VALUES (@customerId, @employeeId, @date, @start, @end);", connection))
                {
                    command.Parameters.AddWithValue("@customerId", booking.customerId);
                    command.Parameters.AddWithValue("@employeeId", booking.employeeId);
                    command.Parameters.AddWithValue("@date", DateTime.Now);
                    command.Parameters.AddWithValue("@start", new TimeSpan(2, 2, 2));
                    command.Parameters.AddWithValue("@end", new TimeSpan(3, 3, 3));
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                            return reader.GetInt32(0);
                }
            }
            return -1;
            // using (var connection = getConnection())
            // {
            //     connection.Open();
            //     Console.WriteLine("Made it here");
            //     using (var command = new MySqlCommand("insert into Bookings(customerId, employeeId, date, start, end) values (@customerId, @employeeId, @date, @start, @end);", connection))
            //     {
            //         command.Parameters.AddWithValue("@customerId", booking.customerId);
            //         command.Parameters.AddWithValue("@employeeId", booking.employeeId);
            //         command.Parameters.AddWithValue("@date", booking.date);
            //         command.Parameters.AddWithValue("@start", booking.start);
            //         command.Parameters.AddWithValue("@end", booking.end);
            //         Console.WriteLine("Made it inside using");
            //         using (var reader = command.ExecuteReader())
            //             while (reader.Read())
            //                 return reader.GetInt32(0);
            //     }
            // }
            // return -1;
        }
        public List<Booking> GetBookingsForCustomer(int customerId)
        {
            List<Booking> bookings = new List<Booking>();
            using (var connection = getConnection())
            {
                connection.Open();

                using (var command = new MySqlCommand("SELECT ID, customerId, employeeId, date, start, end FROM Bookings WHERE customerId = @customerId;", connection))
                {
                    command.Parameters.AddWithValue("@customerId", customerId);
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                            bookings.Add(new Booking(
                                reader.GetInt32("ID"),
                                reader.GetInt32("customerId"),
                                reader.GetInt32("employeeId"),
                                reader.GetDateTime("date"),
                                TimeSpan.Parse(reader.GetString("start")),
                                TimeSpan.Parse(reader.GetString("end"))
                            ));
                }
            }
            return bookings;
        }

        public List<Booking> GetBookingsForEmployee(int employeeId)
        {
            List<Booking> bookings = new List<Booking>();
            using (var connection = getConnection())
            {
                connection.Open();

                using (var command = new MySqlCommand("SELECT ID, customerId, employeeId, date, start, end FROM Bookings WHERE employeeId = @employeeId;", connection))
                {
                    command.Parameters.AddWithValue("@employeeId", employeeId);
                    using (var reader = command.ExecuteReader())
                        while (reader.Read())
                            bookings.Add(new Booking(
                                reader.GetInt32("ID"),
                                reader.GetInt32("customerId"),
                                reader.GetInt32("employeeId"),
                                reader.GetDateTime("date"),
                                TimeSpan.Parse(reader.GetString("start")),
                                TimeSpan.Parse(reader.GetString("end"))
                            ));
                }
            }
            return bookings;
        }

    }
}