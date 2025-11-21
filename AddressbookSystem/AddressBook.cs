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


        public void AddContact(Contacts contact)
        {
            contacts.Add(contact);
            Console.WriteLine("Contact added successfully!");
        }
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
    }
}
