using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class MultipleBooks
    {
        public static Dictionary<string, List<Contact>> addressDictionary = new Dictionary<string, List<Contact>>();

        public void AddressBookDict()
        {
            
            string nameOfDict;

            Console.Write("\nEnter the number of address books you want create: ");
            int numOfAddressBooks = int.Parse(Console.ReadLine());


            for (int a = 1; a <= numOfAddressBooks; a++) 
            {
                Console.Write("Enter the name of Address Book: ");
                nameOfDict = Console.ReadLine();

                if (addressDictionary.Count > 0)
                {
                    if (addressDictionary.ContainsKey(nameOfDict))
                    {
                        Console.WriteLine("Name already exists.");
                    }
                }

                AddMultiple objec = new AddMultiple();
                objec.AddingMultiple();

                addressDictionary.Add(nameOfDict, AddingContacts.AddressBook);
            }
        }
    }
}
