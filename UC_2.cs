using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class UC_2
    {
       
        public void viewing()
        {
            if (UC_1.AddressBook.Count>0)
            {
                foreach (var c in UC_1.AddressBook)
                {
                    PrintValue(c);
                }
            }
            else
            {
                Console.WriteLine("Address book is empty.");
            }
        }


        public void PrintValue(Contacts c)
        {
            Console.WriteLine("First Name: " + c.FirstName);
            Console.WriteLine("Last Name: " + c.LastName);
            Console.WriteLine("Address: " + c.Address);
            Console.WriteLine("City: " + c.City);
            Console.WriteLine("State: " + c.State);
            Console.WriteLine("Zip Code: " + c.ZipCode);
            Console.WriteLine("Phone Number: " + c.PhoneNumber);
            Console.WriteLine("Email Address: " + c.EmailId);
        }
    }
}
