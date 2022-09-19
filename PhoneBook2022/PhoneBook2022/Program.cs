

using PhoneBook.Domain;

namespace PhoneBook2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            TelephoneBook myBook = new TelephoneBook();

            // myBook.AllOrderByLastName()
            //     .ForEach(p => Console.WriteLine(p.FullName));
            string option = "";
            while (option != "x")
            {
                Console.WriteLine("Actions : 1 -> Count, 2->OrderByLastName, 3->AllStartingWith, 4-> AllLastNamesLongerThen, 5->OrderByLastNameLengthDesc, 6->SetPhoneNumber, x->Exit");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine(myBook.Length);
                        break;
                    case "2":
                        // Understand this by looking at the override for "ToString" on person
                        myBook.AllOrderByLastName().ForEach(x => Console.WriteLine(x));
                        break;
                    case "3":
                        {
                            Console.Write("Type starting characters:");
                            var parm = Console.ReadLine();
                            myBook.AllStartingWith(parm).ForEach(x => Console.WriteLine(x));
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("Enter max length:");
                            //optie hieronder -> robuust maken (want conversie -> exceptie)
                            int parm = Convert.ToInt32(Console.ReadLine());
                            //Shorthand voor bovenstaande console writelines
                            myBook.AllLastNamesLongerThen(parm).ForEach(Console.WriteLine);
                            break;
                        }
                    case "5": myBook.OrderByLastNameLengthDesc().ForEach(x => Console.WriteLine(x)); break;
                    case "6":
                        {
                            Console.WriteLine($"There's {myBook.Length} persons in the phonebook. Enter 0 to {myBook.Length - 1}:");
                            int parm = Convert.ToInt32(Console.ReadLine());
                            Console.Write($"Enter phonenumber:");
                            myBook.AddPhoneNumber(parm, Console.ReadLine());
                            break;
                        }
                    default: break;
                }
            }

        }
    }
}