using System;

namespace UC2_AddContactDetails
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
                    Console.WriteLine("--Add Contact Details--");
                    Console.WriteLine("First Name:");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Last Name:");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Address:");
                    string address = Console.ReadLine();
                    Console.WriteLine("City:");
                    string city = Console.ReadLine();
                    Console.WriteLine("State:");
                    string state = Console.ReadLine();
                    Console.WriteLine("Zip Code:");
                    string zip = Console.ReadLine();
                    Console.WriteLine("Phone Number:");
                    string phoneNumber = Console.ReadLine();
                    Console.WriteLine("Email Address:");
                    string email = Console.ReadLine();
                    Console.WriteLine(firstName, lastName, address, city, state, zip, phoneNumber, email);
                    break;
            }

        }
    }
}