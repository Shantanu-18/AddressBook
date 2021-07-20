using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class UC_6
    {
        public static Dictionary<string, List<Contacts>> addressDictionary = new Dictionary<string, List<Contacts>>();

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

                UC_5 objec = new UC_5();
                objec.AddingMultiple();

                addressDictionary.Add(nameOfDict, UC_1.AddressBook);
            }
        }
    }
}
