using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    public class AddressBook
    {
        private List<Contacts> contacts = new List<Contacts>();

        public void AddContact(Contacts contact)
        {
            // Check duplicates by First + Last Name
            foreach (var existing in contacts)
            {
                if (existing.FirstName.Equals(contact.FirstName, StringComparison.OrdinalIgnoreCase) &&
                    existing.LastName.Equals(contact.LastName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Duplicate contact. Not added.");
                    return;
                }
            }
            contacts.Add(contact);
            Console.WriteLine("Contact added successfully!");
        }

        public void DisplayContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts found.");
                return;
            }
            foreach (var c in contacts)
            {
                Console.WriteLine(c);
            }
        }

        public void EditContact(string firstName)
        {
            var contact = contacts.Find(c => c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));
            if (contact == null)
            {
                Console.WriteLine("Contact not found.");
                return;
            }

            Console.Write("New Address: ");
            contact.Address = Console.ReadLine();
            Console.Write("New City: ");
            contact.City = Console.ReadLine();
            Console.Write("New State: ");
            contact.State = Console.ReadLine();
            Console.Write("New Zip: ");
            contact.Zip = Convert.ToInt32(Console.ReadLine());
            Console.Write("New Phone: ");
            contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.Write("New Email: ");
            contact.Email = Console.ReadLine();

            Console.WriteLine("Contact updated!");
        }

        public void DeleteContact(string firstName)
        {
            var contact = contacts.Find(c => c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));
            if (contact == null)
            {
                Console.WriteLine("Contact not found.");
                return;
            }
            contacts.Remove(contact);
            Console.WriteLine("Contact deleted!");
        }
    }
}