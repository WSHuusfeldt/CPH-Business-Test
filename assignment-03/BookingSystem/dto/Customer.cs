namespace BookingSystem.dto {
    public class Customer {
        public int id { get; private set; }
        public string firstname { get; private set; }
        public string lastname { get; private set; }

        public Customer(int id, string firstname, string lastname)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
        }
    }
}