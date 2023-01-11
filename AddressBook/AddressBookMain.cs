using System;
using static System.Console;

namespace AddressBook
{
    public class AddressBookMain
    {
        public List<Contact> Contacts = new List<Contact>();
        public int NumberOfContact { get; set; }

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
            NumberOfContact++;
            DisplayContact();
        }
        public void DisplayContact()
        {
            foreach(var contact in Contacts)
            {
                contact.Display();
            }
            WriteLine("---------------------------------");
        }
        public void EditContact()
        {
            WriteLine("Enter a FirstName to Edit the Contact");string firstname =ReadLine();
            foreach(var contact in Contacts)
            {
                if(contact.FirstName == firstname) { contact.Edit(); }
            }
        }
        public void DeleteContact()
        {
            WriteLine("Enter a firstName or LastName of person to Delete from address book");string name =ReadLine();
            
            foreach(Contact contact in Contacts)
            {
                if (contact.FirstName==name || contact.LastName==name) 
                { Contacts.Remove(contact); 
                    WriteLine("Contact Deleted Successfully");
                    WriteLine("******************************");
                    this.NumberOfContact--;
                    break;

                }
                else
                {
                    WriteLine("Name Does not exist");
                    break;
                }
            }


        }
    }
}