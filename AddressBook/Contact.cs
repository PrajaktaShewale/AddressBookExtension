using System;
using static System.Console;

namespace AddressBook
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }
        public Contact(string FirstName,String LastName,string Address,string City,string State,int ZipCode,long PhoneNumber,string Email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
                this.Address = Address;
            this.City = City;
            this.State = State;
            this.ZipCode = ZipCode;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
        }
        public void Edit()
        {
            WriteLine("Enter a field to Edit from selected COntact");
            WriteLine("1.FirstName 2.LastName 3.Address 4.City 5.State 6.ZipCode 7.PhoneNUmber 8.Email");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1: WriteLine("New FirstName :"); FirstName = ReadLine(); break;
                case 2: WriteLine("New LastName :"); LastName = ReadLine(); break;
                case 3: WriteLine("New Address :"); Address = ReadLine(); break;
                case 4: WriteLine("New City :"); City = ReadLine(); break;
                case 5: WriteLine("New State :"); State = ReadLine(); break;
                case 6: WriteLine("New ZipCode :"); ZipCode = Convert.ToInt32(ReadLine()); break;
                case 7: WriteLine("New PhoneNUmber :"); PhoneNumber = Convert.ToInt64(ReadLine()); break;
                case 8: WriteLine("New Email :"); Email = ReadLine(); break;
                default:
                    break;
            }
        }
        public void Display()
        {
            ForegroundColor = ConsoleColor.Magenta;     
                WriteLine("Name : {0} {1}",FirstName, LastName);
                WriteLine("Address : {0} {1} {2} {3} ", Address, City, State, ZipCode);
                WriteLine("Phone Number : {0}", PhoneNumber);
                WriteLine("Email : {0}", Email);
            ResetColor();
                WriteLine("*--------------********-----------*");
        }
    }
}
