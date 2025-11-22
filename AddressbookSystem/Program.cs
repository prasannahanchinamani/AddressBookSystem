// Default comment from template
using System;
using AddressBookSystem;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Address Book");

        IAddressBook addressBook = new AddressBook();

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Display Contacts");
            Console.WriteLine("3. Edit Contact");
            Console.WriteLine("4. Delete Contact");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter First Name: ");
                    string firstName = Console.ReadLine();

                    Console.Write("Enter Last Name: ");
                    string lastName = Console.ReadLine();

                    Console.Write("Enter Address: ");
                    string address = Console.ReadLine();

                    Console.Write("Enter City: ");
                    string city = Console.ReadLine();

                    Console.Write("Enter State: ");
                    string state = Console.ReadLine();

                    Console.Write("Enter Zip: ");
                    int zip = int.Parse(Console.ReadLine());

                    Console.Write("Enter Phone Number: ");
                    long phoneNumber = long.Parse(Console.ReadLine());

                    Console.Write("Enter Email: ");
                    string email = Console.ReadLine();

                    Contacts newContact = new Contacts(firstName, lastName, address, city, state, zip, phoneNumber, email);
                    addressBook.AddContact(newContact);
                    break;

                case "2":
                    addressBook.DisplayContacts();
                    break;

                case "3":
                    Console.Write("Enter First Name of contact to edit: ");
                    string editFirst = Console.ReadLine();

                    Console.Write("Enter Last Name of contact to edit: ");
                    string editLast = Console.ReadLine();

                    addressBook.EditContact(editFirst, editLast);
                    break;

                case "4":
                    Console.Write("Enter First Name of contact to delete: ");
                    string delFirst = Console.ReadLine();

                    Console.Write("Enter Last Name of contact to delete: ");
                    string delLast = Console.ReadLine();

                    addressBook.DeleteContact(delFirst, delLast);
                    break;

                case "5":
                    exit = true;
                    Console.WriteLine("Exiting Address Book. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}