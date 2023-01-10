using System;
using static System.Console;

namespace AddressBook
{
    public class AddressBookMain
    {
        public List<Contact> Contacts = new List<Contact>();

        public void CreateContact()
        {
            WriteLine("----Add new contact----");
            WriteLine("First Name : ");string Fname=ReadLine();
            WriteLine("Last Name : ");string Lname =ReadLine();
            WriteLine("Address : ");string address =ReadLine();
            WriteLine("City : ");string city =ReadLine();
            WriteLine("State : ");string state =ReadLine();
            WriteLine("ZipCode : ");int zip =Convert.ToInt32(ReadLine());
            WriteLine("Phone Number : ");long phonenumber =Convert.ToInt64(ReadLine());
            WriteLine("Email : ");string email =ReadLine();

            Contact contact = new Contact(Fname, Lname, address, city, state, zip, phonenumber, email);
            Contacts.Add(contact);
        }

        public void DisplayContact()
        {
            foreach(Contact contact in Contacts)
            {
                WriteLine("Name : {0} {1}",contact.FirstName,contact.LastName);
                WriteLine("Address : {0} {1} {2} {3} ", contact.Address, contact.City, contact.State, contact.ZipCode);
                WriteLine("Phone Number : {0}", contact.PhoneNumber);
                WriteLine("Email : {0}", contact.Email);
                WriteLine("*--------------********-----------*");
            }
            
           
        }
    }
}