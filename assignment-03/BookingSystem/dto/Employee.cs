namespace BookingSystem.dto
{
    public class Employee
    {
        public int id { get; private set; }
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public DateTime? birthday { get; private set; }

        public Employee(int id, string firstName, string lastName, DateTime? birthday)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthday = birthday;
        }

        public override bool Equals(object? obj)
        {
            return obj is Employee employee &&
                   id == employee.id &&
                   firstName == employee.firstName &&
                   lastName == employee.lastName &&
                   birthday == employee.birthday;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, firstName, lastName, birthday);
        }
    }
}