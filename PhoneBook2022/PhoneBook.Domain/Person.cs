namespace PhoneBook.Domain
{
    public class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelephoneNumber { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public override string ToString()
        {
            return $"{FullName} {TelephoneNumber}";
        }
    }
}