using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook
{
    public class EditingContacts
    {
        public void Editing()
        {
            if (AddingContacts.AddressBook.Count>0)
            {
                Console.Write("Enter Name of the contact you want to edit: ");
                string editName = Console.ReadLine();

                

                foreach (var c in AddingContacts.AddressBook)
                {
                    if (editName.ToLower() == c.FirstName.ToLower())
                    {
                        Console.WriteLine("\nChoice what you want to edit\n 1.First name\n2.Last name\n3.Address" +
                            "\n4.City\n5.State\n6.Zip Code\n7.Phone Number\n8.Email");

                        int editChoice = int.Parse(Console.ReadLine());

                        switch (editChoice)
                        {
                            case 1:
                                Console.Write("Enter new First Name: ");
                                c.FirstName = Console.ReadLine();
                                break;

                            case 2:
                                Console.Write("Enter new Last Name: ");
                                c.LastName = Console.ReadLine();
                                break;

                            case 3:
                                Console.Write("Enter Your new Address: ");
                                c.Address = Console.ReadLine();
                                break;

                            case 4:
                                Console.Write("Enter Your new City Name: ");
                                c.City = Console.ReadLine();
                                break;

                            case 5:
                                Console.Write("Enter new State Name: ");
                                c.State = Console.ReadLine();
                                break;

                            case 6:
                                while (true)
                                {
                                    Console.Write("Enter new Zip Code: ");
                                    string code = Console.ReadLine();

                                    if (code.Length == 6)
                                    {
                                        c.ZipCode = code;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Enter a valid 6 digit Zip Code.");
                                    }
                                }
                                break;

                            case 7:
                                while (true)
                                {
                                    Console.Write("Enter Your new Phone Number: ");
                                    string number = Console.ReadLine();

                                    if (number.Length == 10)
                                    {
                                        c.PhoneNumber = number;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Enter a valid 10 digit Phone Number.");
                                    }
                                }
                                break;

                            case 8:
                                while (true)
                                {
                                    Console.Write("Enter Your new Email Address: ");
                                    string mail = Console.ReadLine();

                                    if (mail.Contains("@"))
                                    {
                                        c.EmailId = mail;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Enter a valid Email Address.");
                                    }
                                }
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("{0} does not exists in Address Book.",editName);
                    }
                }
            }
        }
    }
}
