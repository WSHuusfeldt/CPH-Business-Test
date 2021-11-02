namespace BookingSystem.dto
{
    public class Employee
    {
        public int id { get; private set; }
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public DateTime? birthday { get; private set; }

        public Employee(int id, string firstName, string lastName, DateTime birthday)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthday = birthday;
        }

    }
}