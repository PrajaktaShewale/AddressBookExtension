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

            AddressBookMain book = new AddressBookMain();
            bool option = false;            
            while (!option)
            {
                WriteLine("1.Create Contact\n2.EditContact\n3.Delete Contact \n4.DisplayContact");
                int choice = Convert.ToInt32(ReadLine());
                switch (choice)
                {
                    case 1: book.CreateContact(); break;
                    case 2: if (book.NumberOfContact > 0) { book.EditContact(); } else { WriteLine("Add Atleast One Contact"); } break;
                    case 3: if (book.NumberOfContact > 0) { book.DeleteContact(); } else { WriteLine("Add Atleast One Contact"); } break;
                    case 4: if (book.NumberOfContact > 0) { book.DisplayContact(); } else { WriteLine("There are no any contact"); } break;
                }
                
            }
            
        }
    }
}