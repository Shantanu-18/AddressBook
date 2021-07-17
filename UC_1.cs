using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class UC_1
    {
        public static List<Contacts> AddressBook = new List<Contacts>();

        public void UserInput()
        {
            Contacts contacts = new Contacts();

            Console.Write("Enter First Name: ");
            contacts.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            contacts.LastName = Console.ReadLine();

            Console.Write("Enter Your Address: ");
            contacts.Address = Console.ReadLine();

            Console.Write("Enter Your City Name: ");
            contacts.City = Console.ReadLine();

            Console.Write("Enter State Name: ");
            contacts.State = Console.ReadLine();

            while(true)
            {
                Console.Write("Enter Zip Code of your area: ");
                string code = Console.ReadLine();

                if (code.Length == 6)
                {
                    contacts.ZipCode = code;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid 6 digit Zip Code.");
                }
            }

            while (true)
            {
                Console.Write("Enter Your Phone Number: ");
                string number = Console.ReadLine();

                if (number.Length == 10)
                {
                    contacts.PhoneNumber = number;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid 10 digit Phone Number.");
                }
            }

            while (true)
            {
                Console.Write("Enter Your Email Address: ");
                string mail = Console.ReadLine();

                if (mail.Contains("@"))
                {
                    contacts.EmailId = mail;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid Email Address.");
                }
            }
            AddressBook.Add(contacts);

            Console.WriteLine("--------> Added Successfully <--------");
        }
    }
}
