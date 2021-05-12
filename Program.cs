using System;

namespace UC1_AddressBook
{
    class Address_book
    {

        static String firstName;
        static String lastName;
        static String city;
        static String state;
        static String address;
        static String email;
        static long zipCode;
        static long phoneNumber;
        public Address_book(String firstName, String lastName, String address, String city, String state, long phoneNumber, String email, long zipCode)
        {
            Address_book.firstName = firstName;
            Address_book.lastName = lastName;
            Address_book.address = address;
            Address_book.city = city;
            Address_book.state = state;
            Address_book.zipCode = zipCode;
            Address_book.phoneNumber = phoneNumber;
            Address_book.email = email;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("***************************");
            Console.WriteLine("Welcome To The Address Book");
            Console.WriteLine("***************************");

            Console.WriteLine("--Create Contact Details--");
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
        
                        
                }
            }
        }

