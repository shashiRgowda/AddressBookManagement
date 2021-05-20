using System;

namespace AddressBook
{
    public class ContactList
    {
        private String firstName;
        private String lastName;
        private String address;
        private String city;
        private String state;
        private String zip;
        private String phoneNumber;
        private String email;

        public ContactList(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***************************");
            Console.WriteLine("Welcome To The Address Book");
            Console.WriteLine("***************************");
            Console.WriteLine("Add Contact Details");
            Console.WriteLine("1.First Name");
            Console.WriteLine("2.Last Name");
            Console.WriteLine("3.Address");
            Console.WriteLine("4.City");
            Console.WriteLine("5.State");
            Console.WriteLine("6.ZipCode");
            Console.WriteLine("7.Phone Number");
            Console.WriteLine("8.Email");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Edit? Old FirstName: " + contact.Value.FirstName);
                    string newFirstName = Console.ReadLine();
                    Console.WriteLine("Edit? Old LastName: " + contact.Value.LastName);
                    string newLastName = Console.ReadLine();
                    Console.WriteLine("Edit? Old Address: " + contact.Value.Address);
                    string newAddress = Console.ReadLine();
                    Console.WriteLine("Edit? Old City: " + contact.Value.City);
                    string newCity = Console.ReadLine();
                    Console.WriteLine("Edit? Old State: " + contact.Value.State);
                    string newState = Console.ReadLine();
                    Console.WriteLine("Edit? Old ZipCode: " + contact.Value.Zip);
                    string newZip = Console.ReadLine();
                    Console.WriteLine("Edit? Old Phone Number: " + contact.Value.PhoneNumber);
                    string newPhoneNumber = Console.ReadLine();
                    Console.WriteLine("Edit? Old Email: " + contact.Value.Email);
                    string newEmail = Console.ReadLine();
                    break;

                    case 2;
                    break;


                    case 3;
                    break;


                    case 4;
                    person.display();
                    break;


                    case 5;
                    break;

            }

        }
    }
}