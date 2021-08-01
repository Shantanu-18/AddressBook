using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class Displaying : MultipleBooks
    {
        public void dictview()
        {
            if (addressDictionary.Count>0)
            {
                foreach (KeyValuePair<string, List<Contact>> dict in addressDictionary)
                {

                    Console.WriteLine("-----------> {0}'s address book <-----------", dict.Key);
                    foreach (var c in dict.Value)
                    {
                        PrintValue(c);
                        Console.WriteLine("---------------------------");                                     //For Separation
                    }
                }
            }
            else
            {
                Console.WriteLine("Address book is empty.");
            }
        }


        public void PrintValue(Contact c)
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
