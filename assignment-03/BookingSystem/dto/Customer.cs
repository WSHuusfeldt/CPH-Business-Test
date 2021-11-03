namespace BookingSystem.dto
{
    public class Customer
    {
        public int id { get; private set; }
        public string firstname { get; private set; }
        public string lastname { get; private set; }
        public DateTime? birthday { get; private set; }
        public string? phoneNumber { get; private set; }

        public Customer(int id, string firstname, string lastname, DateTime birthday, string phoneNumber)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.birthday = birthday;
            this.phoneNumber = phoneNumber;
        }

        public Customer(int id, string firstname, string lastname)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public override bool Equals(object? obj)
        {
            return obj is Customer customer &&
                   id == customer.id &&
                   firstname == customer.firstname &&
                   lastname == customer.lastname &&
                   birthday == customer.birthday &&
                   phoneNumber == customer.phoneNumber;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, firstname, lastname, birthday, phoneNumber);
        }
    }
}