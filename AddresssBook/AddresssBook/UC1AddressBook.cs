using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddresssBook
{
    public class UC1AddressBook
    {
        string firstName;
        string lastName;
        string[] address = new string[2];
        string state;
        int zipCode;
        long phoneNumber;
        string email;
        //ArrayList arlist = new ArrayList();
        public void GetContactDetails()   // creating contact details of person
        {

            Console.WriteLine("Enter the First Name");
            firstName = Console.ReadLine();
            // arlist.Add(firstName);

            Console.WriteLine("Enter the Last Name");
            lastName = Console.ReadLine();
            // arlist.Add(lastName);

            Console.WriteLine("Enter the Adresss");
            address[0] = Console.ReadLine();
            // arlist.Add(address[0]);


            Console.WriteLine("Enter the State");
            state = Console.ReadLine();
            //   arlist.Add(state);

            Console.WriteLine("Enter the Zip Code");
            zipCode = Convert.ToInt32(Console.ReadLine());
            //arlist.Add(zipCode);

            Console.WriteLine("Enter the Phone Number");
            // int[] phoneNumber = new int[10];
            phoneNumber = Convert.ToInt64(Console.ReadLine());
            //         arlist.Add(phoneNumber);

            Console.WriteLine("Enter the Email");
            email = Console.ReadLine();
            //       arlist.Add(email);


        }

        public void putDetails() // displaying contact details
        {
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);
            Console.WriteLine("Address: " + address[0]);
            Console.WriteLine("state: " + state);
            Console.WriteLine("Zip Code: " + zipCode);
            Console.WriteLine("Phone NUmber: " + phoneNumber);
            Console.WriteLine("Email: " + email);

            /* for (int i = 0; i < arlist.Count; i++)
             {
                 Console.WriteLine("\n====The Contact Details===\n");
                 Console.Write(arlist[i] + "  ");
             }  */

        }

    }
}
