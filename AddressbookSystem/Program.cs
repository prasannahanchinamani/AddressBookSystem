// Default comment from template
using AddressBookSystem;

Console.WriteLine("Welcome to Address Book");

Contacts contact = new Contacts("Prasanna", "Kumar", "123 Main St",
                                "Bengaluru", "KA", 560076, 9876543210, "prasanna@example.com");

<<<<<<< HEAD
Console.WriteLine(contact); 
=======
//Console.WriteLine(contact);

AddressBook addressBook = new AddressBook();
addressBook.AddContact(contact);
addressBook.DisplayContacts();
>>>>>>> addressbook
