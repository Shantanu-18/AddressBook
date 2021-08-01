using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class Deleting
    {
        public void Delete()
        {
            if (AddingContacts.AddressBook.Count>0)
            {
                Console.Write("Enter name of contact you want to delete: ");
                string deleteName = Console.ReadLine();


                foreach (var c in AddingContacts.AddressBook)
                {
                    if (deleteName.ToLower() == c.FirstName.ToLower())
                    {
                        AddingContacts.AddressBook.Remove(c);
                        Console.WriteLine(deleteName + "'s Contact is successfully deleted.");
                        break;
                    }

                    else
                    {
                        Console.WriteLine(deleteName + " does not exist in Address Book.");
                    }
                }
            }

            else
            {
                Console.WriteLine("Address Book is empty.");
            }
        }
    }
}
