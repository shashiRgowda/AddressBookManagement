using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================\nChoose the operation:\n1.Add Another Contact.\n2.View Saved Contact.\n3.Edit Existing Contact.\n4.Delete Existing Contact.\n5.Exit Adress Book Application.\n=================================");
            var userInput = Console.ReadLine();
            var addressBook = new AddressBookMain();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("First Name:");
                        string firstname = Console.ReadLine();
                        Console.WriteLine("Last Name:");
                        string lastname = Console.ReadLine();
                        Console.WriteLine("Address:");
                        string address = Console.ReadLine();
                        Console.WriteLine("City:");
                        string city = Console.ReadLine();
                        Console.WriteLine("State:");
                        string state = Console.ReadLine();
                        Console.WriteLine("Zip Code:");
                        string zipcode = Console.ReadLine();
                        Console.WriteLine("Phone Number:");
                        string phonenumber = Console.ReadLine();
                        Console.WriteLine("Email:");
                        string email = Console.ReadLine();
                        var newContact = new Contact(firstname, lastname, address, city, state, zipcode, phonenumber, email);
                        addressBook.AddContact(newContact);
                        break;
                    case "2":
                        addressBook.DisplayAllContact();
                        break;
                    case "3":
                        Console.WriteLine("Enter First Name of the Contact you want to edit:");
                        string personName = Console.ReadLine();
                        addressBook.EditContact(personName);
                        break;
                    case "4":
                        Console.WriteLine("Enter First Name of the Contact you want to Delete:");
                        string name = Console.ReadLine();
                        addressBook.DeleteContact(name);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Choose valid operation.");
                        break;

                }
                Console.WriteLine("=================================\nChoose the operation:\n1.Add Another Contact.\n2.View Saved Contact.\n3.Edit Existing Contact.\n4.Delete Existing Contact.\n5.Exit Adress Book Application.\n=================================");
                userInput = Console.ReadLine();
            }
        }
    }

}