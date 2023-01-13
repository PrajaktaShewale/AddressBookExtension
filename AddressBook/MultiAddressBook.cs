using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AddressBook
{
    public class MultiAddressBook
    {
        public Dictionary<string, AddressBookMain> books = new Dictionary<string, AddressBookMain>();
        public int NumberOfBook { get; set; }
        public string AddBook()
        {
            WriteLine("Create a New Contact");
            WriteLine("Please Enter Name Of Book : "); String bname=ReadLine();
            if (books.ContainsKey(bname))//checked in dictionary key is same as input
            { WriteLine("Sorry This Name Already Taken"); return null; }
            else
            {
                books[bname] = new AddressBookMain();
                WriteLine("New Book Has Been Created");
                return bname;
            }
        }
        public void DisplayBook()
        {
            foreach(var book in books.Keys) { WriteLine(book); }
        }
        public AddressBookMain OpenBook(string bname)
        {
            return books[bname];
        }
        public string ChangeAddressBook()
        {
            WriteLine("*****change Book******\n Books Already Exist in Book List");
            DisplayBook();
            WriteLine("Enter Name Of BOOK");string name =ReadLine();
            return name;

        }
    }
}
