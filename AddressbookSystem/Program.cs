// Default comment from template
using AddressBookSystem;

Console.WriteLine("Welcome to Address Book");

Contacts contact = new Contacts("Prasanna", "Kumar", "123 Main St",
                                "Bengaluru", "KA", 560076, 9876543210, "prasanna@example.com");

<<<<<<< HEAD
//<<<<<<< HEAD
Console.WriteLine(contact); 
//=======
=======
>>>>>>> EditContactBasedOnName
//Console.WriteLine(contact);

AddressBook addressBook = new AddressBook();
addressBook.AddContact(contact);
<<<<<<< HEAD
addressBook.DisplayContacts();
//>>>>>>> addressbook
=======
addressBook.DisplayContacts();
>>>>>>> EditContactBasedOnName
