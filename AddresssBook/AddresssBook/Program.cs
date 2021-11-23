// See https://aka.ms/new-console-template for more information
using System;

namespace AddresssBook
{
    class Program
    {
        static void Main(string[] args)

        {
            

                UC6AddressBook book = new UC6AddressBook(); // creating object of class
                string yes = "y";
                string y;

                Console.WriteLine("enter the address book name");
                string bookName = Console.ReadLine();

                Dictionary<UC6AddressBook, string> dic = new Dictionary<UC6AddressBook, string>();
                dic.Add(book, bookName);
                display(dic);
 

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
                        case 2:
                            book.ContactDetails();
                            break;

                        case 3:
                            book.editContact();
                            break;

                        case 4:
                            book.RemoveContact();
                            break;

                        default:
                            break;
                    }
                    Console.WriteLine("\ndo you want to continue? press...y/n");
                    y = Console.ReadLine();
                }
                while (yes == y);
            Console.ReadLine();                           
            }
        public static void display(Dictionary<UC6AddressBook, string> dic)
        {
            foreach (var e in dic)
            {
                Console.WriteLine("the address Book are");
                Console.WriteLine(e.Value);
            }
        }
    }
}
