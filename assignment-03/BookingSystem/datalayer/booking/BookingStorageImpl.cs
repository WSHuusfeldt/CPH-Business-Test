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
                Console.WriteLine("Made it here");
                using (var command = new MySqlCommand("insert into Bookings(customerId, employeeId, date, start, end) values (@customerId, @employeeId, @date, @start, @end); SELECT last_insert_id()", connection))
                {
                    command.Parameters.AddWithValue("@customerId", booking.customerId);
                    command.Parameters.AddWithValue("@employeeId", booking.employeeId);
                    command.Parameters.AddWithValue("@date", booking.date);
                    command.Parameters.AddWithValue("@start", booking.start);
                    command.Parameters.AddWithValue("@end", booking.end);

                    return (int)(ulong)command.ExecuteScalar();
                }
            }
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
                                reader.GetTimeSpan("start"),
                                reader.GetTimeSpan("end")
                            // TimeSpan.Parse(reader.GetString("start")),
                            // TimeSpan.Parse(reader.GetString("end"))
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
                                reader.GetTimeSpan("start"),
                                reader.GetTimeSpan("end")
                            ));
                }
            }
            return bookings;
        }

        public Booking GetBooking(int bookingId) {
            using (var connection = getConnection())
            {
                connection.Open();

                using (var command = new MySqlCommand("SELECT ID, customerId, employeeId, date, start, end FROM Bookings WHERE ID = @ID;", connection))
                {
                    command.Parameters.AddWithValue("@ID", bookingId);
                    using (var reader = command.ExecuteReader())
                        return reader.Read() ?
                            new Booking(
                                reader.GetInt32("ID"),
                                reader.GetInt32("customerId"),
                                reader.GetInt32("employeeId"),
                                reader.GetDateTime("date"),
                                reader.GetTimeSpan("start"),
                                reader.GetTimeSpan("end")
                            ) : null;
                }
            }
        }

    }
}