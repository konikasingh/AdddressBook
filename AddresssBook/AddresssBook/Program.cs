// See https://aka.ms/new-console-template for more information
using System;

namespace AddresssBook
{
    class Program
    {
        static void Main(string[] args)

        {
            

                UC9AddressBook Person = new UC9AddressBook(); // creating object of class
                string yes = "y";
                string y;

                Console.WriteLine("enter the address book name");
                string bookName = Console.ReadLine();

                Dictionary<UC9AddressBook, string> dic = new Dictionary<UC9AddressBook, string>();
                dic.Add(Person, bookName);
                display(dic);
 

            do
            {

                    Console.WriteLine("Welcome to Address Book");
                    Console.WriteLine("1.AddNewContact\n2.ShowContact\n3.EditContact\n4.RmoveContact\n5.SearchCity\n6.SearchState\n7.ViewByCityOrStateName");
                    Console.WriteLine("\nEnter your choice");
                    int ch = Convert.ToInt32(Console.ReadLine());


                    switch (ch)
                    {

                        case 1:
                            Console.WriteLine("how many contact you want to add:");
                            int n = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < n; i++)
                            {
                            Person.GetContactDetails();
                            }
                            break;
                        case 2:
                            Person.ContactDetails();
                            break;

                        case 3:
                            Person.editContact();
                            break;

                        case 4:
                            Person.RemoveContact();
                            break;
                        case 5:
                            Person.SearchCity();
                            break;
                        case 6:
                            Person.SearchState();
                            break;
                        case 7:
                            Person.ViewByCityOrStateName();
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
        public static void display(Dictionary<UC9AddressBook, string> dic)
        {
            foreach (var e in dic)
            {
                Console.WriteLine("the address Book are");
                Console.WriteLine(e.Value);
            }
        }
    }
}
