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
            Console.WriteLine("Dispalaying contacts");
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }
    }
}
