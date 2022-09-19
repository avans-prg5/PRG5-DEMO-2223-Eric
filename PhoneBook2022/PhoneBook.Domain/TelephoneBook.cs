using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Domain
{
    /// <summary>
    /// Mijn eerste telefoonboek
    /// </summary>
    public class TelephoneBook
    {
        private List<Person> AllPersons;
        public int TelephoneBookLenght { get { return AllPersons.Count(); } }
        public TelephoneBook()
        {
            AllPersons = new List<Person>();
            AllPersons.Add(new Person("Eric", "Kuijpers"));
            AllPersons.Add(new Person("Klaas", "Vaak"));
            AllPersons.Add(new Person("Bilbo", "Baggins"));
            AllPersons.Add(new Person("Frodo", "Baggins"));
            AllPersons.Add(new Person("Koek", "Waus"));
            AllPersons.Add(new Person("Pietje", "Puk"));
            AllPersons.Add(new Person("Niels", "Holgerson"));
            AllPersons.Add(new Person("Alfred-Jodocus", "Kwak"));
            AllPersons.Add(new Person("An", "Oniem"));
        }

        public int Length => AllPersons?.Count ?? 0;

        public void AddPhoneNumber(int index, string phoneNumber)
        {
            if ((AllPersons?.Count ?? -1) >= index)
            {
                AllPersons[index].TelephoneNumber = phoneNumber;
            }
        }

        /// <summary>
        /// sorteren op achternaam
        /// </summary>
        /// <returns></returns>
        public List<Person> AllOrderByLastName() => AllPersons.OrderBy(x => x.LastName).ToList();


        /// <summary>
        /// Sorteren op achternaam
        /// </summary>
        /// <param name="firstNameStartsWith"></param>
        /// <returns></returns>
        public List<Person> AllStartingWith(string firstNameStartsWith) =>
            AllPersons.Where(i => i.FirstName.StartsWith(firstNameStartsWith))
                .OrderBy(x => x.LastName).ToList();

        public List<Person> AllLastNamesLongerThen(int minLength) =>
            AllPersons.Where(i => i.LastName.Length > minLength).ToList();


        public List<Person> OrderByLastNameLengthDesc() =>
            AllPersons.OrderByDescending(i => i.LastName.Length).ToList();

    }
}
