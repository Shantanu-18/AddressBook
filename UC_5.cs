using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class UC_5
    {
        public void AddingMultiple()
        {
            Console.WriteLine("Enter how many contacts you want to add: ");
            int numberOfContacts = int.Parse(Console.ReadLine());

            int i = 1;

            while (i <= numberOfContacts) 
            {
                UC_1 multi = new UC_1();
                multi.UserInput();
                i++;
                Console.WriteLine("{0} contact is added.",i-1);
            }

        }
    }
}
