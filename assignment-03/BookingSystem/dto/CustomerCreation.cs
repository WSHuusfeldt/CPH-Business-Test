namespace BookingSystem.dto
{
    public class CustomerCreation
    {
        public string firstname { get; private set; }
        public string lastname { get; private set; }

        public CustomerCreation(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }
    }
}