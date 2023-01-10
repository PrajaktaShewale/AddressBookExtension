namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("#------Welcome to Address Book Program------#");
            Console.ResetColor();

            AddressBookMain book = new AddressBookMain();
            bool addcontact = true;            
            while (addcontact)
            {
                book.CreateContact();
                Console.WriteLine("Do you want to add more contact?(Y/N) :");
                string ans = Console.ReadLine();
                if(ans =="N" || ans == "n") { addcontact = false; }
            }
            book.DisplayContact();
        }
    }
}