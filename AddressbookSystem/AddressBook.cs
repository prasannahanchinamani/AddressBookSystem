using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    public class AddressBook
    {
        private List<Contacts> contacts;

        public AddressBook()
        {
            contacts = new List<Contacts>();
        }

        // Add a new contact
        public void AddContact(Contacts contact)
        {
            contacts.Add(contact);
            Console.WriteLine("Contact added successfully!");
        }

        // Edit an existing contact by first name
        public void EditContact(string firstName)
        {
            firstName = firstName.ToLower();
            Contacts contactToEdit = contacts.Find(c => c.FirstName.ToLower().Equals(firstName));

            if (contactToEdit != null)
            {
                Console.WriteLine($"Editing contact: {contactToEdit.FirstName} {contactToEdit.LastName}");

                Console.Write("Enter new address: ");
                contactToEdit.Address = Console.ReadLine();

                Console.Write("Enter new city: ");
                contactToEdit.City = Console.ReadLine();

                Console.Write("Enter new state: ");
                contactToEdit.State = Console.ReadLine();

                Console.Write("Enter new zip: ");
                contactToEdit.Zip = int.Parse(Console.ReadLine());

                Console.Write("Enter new phone number: ");
                contactToEdit.PhoneNumber = long.Parse(Console.ReadLine());

                Console.Write("Enter new email: ");
                contactToEdit.Email = Console.ReadLine();

                Console.WriteLine("Contact updated successfully!");
            }
            else
            {
                Console.WriteLine($"Contact with name '{firstName}' not found.");
            }
        }
    }
}