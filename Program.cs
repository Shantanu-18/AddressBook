using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book.");


            MultipleBooks dict = new MultipleBooks();
            dict.AddressBookDict();

            while (true)
            {
                Console.WriteLine("\nEnter your choice \n 1 for viewing Address book \n 2 for editing the existing contact" +
                   " \n 3 for deleting contact");

                int choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    //case 1:
                    //    UC_1 obj = new UC_1();
                    //    obj.UserInput();
                    //    break;

                    case 1:
                        Displaying obj1 = new Displaying();
                        //obj1.viewing();
                        obj1.dictview();
                        break;

                    case 2:
                        EditingContacts obj2 = new EditingContacts();
                        obj2.Editing();
                        break;

                    case 3:
                        Deleting obj3 = new Deleting();
                        obj3.Delete();
                        break;

                    //case 5:
                    //    UC_5 obj4 = new UC_5();
                    //    obj4.AddingMultiple();
                    //    break;

                    default:
                        Console.WriteLine("Enter valid choice.");
                        break;
                }

            }
        }
    }
}
