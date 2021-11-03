namespace BookingSystem.dto
{
    public class Customer
    {
        public int id { get; private set; }
        public string firstname { get; private set; }
        public string lastname { get; private set; }
        public DateTime birthday { get; private set; }
        public string phoneNumber { get; private set; }

        public Customer(int id, string firstname, string lastname, DateTime birthday, string phoneNumber)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.birthday = birthday;
            this.phoneNumber = phoneNumber;
        }
    }
}