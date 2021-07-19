using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book.");

            while (true)
            {
                Console.WriteLine("\nEnter your choice \n 1 for Adding Contacts \n 2 for viewing Address book" +
                    " \n 3 for editing the existing contact \n 4 for deleting contact \n 5 for adding multiple contacts");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        UC_1 obj = new UC_1();
                        obj.UserInput();
                        break;

                    case 2:
                        UC_2 obj1 = new UC_2();
                        obj1.viewing();
                        break;

                    case 3:
                        UC_3 obj2 = new UC_3();
                        obj2.Editing();
                        break;

                    case 4:
                        UC_4 obj3 = new UC_4();
                        obj3.Delete();
                        break;

                    case 5:
                        UC_5 obj4 = new UC_5();
                        obj4.AddingMultiple();
                        break;

                    default:
                        Console.WriteLine("Enter valid choice.");
                        break;


                }
            }
        }
    }
}
