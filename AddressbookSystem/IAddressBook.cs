namespace AddressBookSystem
{
    // Abstraction: interface defines contract
    public interface IAddressBook
    {
        void AddContact(Contacts contact);   
        void EditContact(string firstName,String lastName);  
        void DeleteContact(string firstName,String lastName);
        void DisplayContacts();             
    }
}