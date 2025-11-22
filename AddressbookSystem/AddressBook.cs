using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    // Inheritance: AddressBook implements IAddressBook
    public class AddressBook : IAddressBook
    {
        private List<Contacts> contacts;

        public AddressBook()
        {
            contacts = new List<Contacts>();
        }

        // Implementation of AddContact
        public void AddContact(Contacts contact)
        {
            bool duplicateFound = false;
            foreach (var existingContact in contacts)
            {
                if (existingContact.FirstName.ToLower().Equals(contact.FirstName.ToLower()) &&
                    existingContact.LastName.ToLower().Equals(contact.LastName.ToLower()))
                {
                    duplicateFound = true;
                    break;
                }
            }

            if (duplicateFound)
            {
                Console.WriteLine($"Contact {contact.FirstName} {contact.LastName} already exists. Duplicate not added.");
            }
            else
            {
                contacts.Add(contact);
                Console.WriteLine("Contact added successfully!");
            }
        }

        // Implementation of DisplayContacts
        public void DisplayContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts found in the Address Book.");
                return;
            }

            Console.WriteLine("\n--- Address Book Contacts ---");
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }

        // Implementation of EditContact
        public void EditContact(string firstName, string lastName)
        {
            firstName = firstName.ToLower();
            lastName = lastName.ToLower();

            Contacts contactToEdit = contacts.Find(c =>
                c.FirstName.ToLower().Equals(firstName.ToLower()) &&
                c.LastName.ToLower().Equals(lastName.ToLower()));

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
                Console.WriteLine($"Contact {firstName} {lastName} not found.");
            }
        }

        // Implementation of DeleteContact
        public void DeleteContact(string firstName, string lastName)
        {
            firstName = firstName.ToLower();
            lastName = lastName.ToLower();

            Contacts contactToDelete = contacts.Find(c =>
                c.FirstName.ToLower().Equals(firstName) &&
                c.LastName.ToLower().Equals(lastName));

            if (contactToDelete != null)
            {
                contacts.Remove(contactToDelete);
                Console.WriteLine($"Contact {firstName} {lastName} deleted successfully!");
            }
            else
            {
                Console.WriteLine($"Contact {firstName} {lastName} not found.");
            }
        }
    }
}