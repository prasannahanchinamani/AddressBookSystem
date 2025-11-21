using System;
using AddressBookSystem;

class Program
{
    static void Main()
    {
        AddressBook addressBook = new AddressBook();
        bool exit = false;

        Console.WriteLine("Welcome to Address Book");

        while (!exit)
        {
            Console.WriteLine("\n1. Add Contact\n2. Display Contacts\n3. Edit Contact\n4. Delete Contact\n5. Exit");
            Console.Write("Choose: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("First Name: ");
                    string fn = Console.ReadLine();
                    Console.Write("Last Name: ");
                    string ln = Console.ReadLine();
                    Console.Write("Address: ");
                    string addr = Console.ReadLine();
                    Console.Write("City: ");
                    string city = Console.ReadLine();
                    Console.Write("State: ");
                    string state = Console.ReadLine();
                    Console.Write("Zip (6 digits): ");
                    int zip = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Phone (10 digits): ");
                    long phone = Convert.ToInt64(Console.ReadLine());
                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    Contacts c = new Contacts(fn, ln, addr, city, state, zip, phone, email);
                    addressBook.AddContact(c);
                    break;

                case 2:
                    addressBook.DisplayContacts();
                    break;

                case 3:
                    Console.Write("Enter First Name to edit: ");
                    addressBook.EditContact(Console.ReadLine());
                    break;

                case 4:
                    Console.Write("Enter First Name to delete: ");
                    addressBook.DeleteContact(Console.ReadLine());
                    break;

                case 5:
                    exit = true;
                    Console.WriteLine("Goodbye!");
                    break;
            }
        }
    }
}