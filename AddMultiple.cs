using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class AddMultiple
    {
        public void AddingMultiple()
        {
            Console.Write("Enter how many contacts you want to add: ");
            int numberOfContacts = int.Parse(Console.ReadLine());

            int i = 1;

            while (i <= numberOfContacts) 
            {
                AddingContacts multi = new AddingContacts();
                multi.UserInput();
                i++;
                Console.WriteLine("{0} contact is added.",i-1);
            }

        }
    }
}
