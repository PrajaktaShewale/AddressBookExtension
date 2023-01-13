using static System.Console;
namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("#------Welcome to Address Book Program------#");
            ResetColor();

            MultiAddressBook multiAddressBook = new MultiAddressBook();
            string name = multiAddressBook.AddBook();
            if (name != null)
            {
                bool exit = false;
                while (!exit)
                {
                    AddressBookMain book = multiAddressBook.OpenBook(name);
                    WriteLine("This is Address Book: " + $" {name} ");
                    WriteLine("1.Create Contact\n2.EditContact\n3.Delete Contact \n4.DisplayContact\n5Change Address Book\n6.Create New Address Book");
                    int choice = Convert.ToInt32(ReadLine());
                    switch (choice)
                    {
                        case 1: book.CreateContact(); break;
                        case 2: if (book.NumberOfContact > 0) { book.EditContact(); } else { WriteLine("Add Atleast One Contact"); } break;
                        case 3: if (book.NumberOfContact > 0) { book.DeleteContact(); } else { WriteLine("Add Atleast One Contact"); } break;
                        case 4: if (book.NumberOfContact > 0) { book.DisplayContact(); } else { WriteLine("There are no any contact"); } break;
                        case 5: name = multiAddressBook.ChangeAddressBook(); break;
                        case 6: name = multiAddressBook.AddBook(); break;
                            default:
                            break;
                    }
                    WriteLine("---------*****-----------");
                }
            }           
        }
    }
}