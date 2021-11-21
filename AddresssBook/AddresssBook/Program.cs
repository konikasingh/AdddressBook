// See https://aka.ms/new-console-template for more information
using System;

namespace AddresssBook
{
    class Program
    {
        static void Main(string[] args)
        {
            UC1AddressBook book = new UC1AddressBook(); // creating object of class
            string yes = "y";
            string y;

            do
            {

                Console.WriteLine("Welcome to Address Book");
                Console.WriteLine("1.AddNewContact\n2.ShowContact\n3.EditContact\n4.RmoveContact");
                Console.WriteLine("\nEnter your choice");
                int ch = Convert.ToInt32(Console.ReadLine());


                switch (ch)
                {

                    case 1:
                        Console.WriteLine("how many contact you want to add:");
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            book.GetContactDetails();
                        }
                        break;
                    //case 2:
                    //    book.ContactDetails();
                    //    break;

                    //case 3:
                    //    book.editContact();
                    //    break;

                    //case 4:
                    //    book.removeContact();
                    //    break;

                    //default:
                    //    break;
                }
                Console.WriteLine("\ndo you want to continue? press...y/n");
                y = Console.ReadLine();


            } while (yes == y);
            Console.ReadLine();

        }
    }
}
