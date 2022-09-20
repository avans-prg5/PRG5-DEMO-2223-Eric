using PhoneBook.Domain;

namespace PhoneBook2022.WebMVC.Models
{
    public class PersonModel
    {
        public string FirstName { get; set; }   
        public string LastName { get; set; }    
        public int Id { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public string TelephoneNumber { get; set; }
        public PersonModel()
        {
        }
        public PersonModel(Person source)
        {
            this.FirstName = source.FirstName;
            this.TelephoneNumber = source.TelephoneNumber;
            this.LastName = source.LastName;
        }
    }
}
