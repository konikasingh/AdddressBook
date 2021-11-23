using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace AddresssBook
{
    public class UC5AddressBook
    {

        private LinkedList<ContactList> addressBook = new LinkedList<ContactList>();  //here created the empty LinkedList object 


        public string firstName;
        public string lastName;
        public string[] address = new string[2];
        public string state;
        public int zipCode;
        public long phoneNumber;
        public string email;

      
        public void GetContactDetails()   // creating contact details of person
        {


            Console.WriteLine("Enter the First Name");
            firstName = Console.ReadLine();

            Console.WriteLine("Enter the Last Name");
            lastName = Console.ReadLine();

            Console.WriteLine("Enter the Adresss");
            address[0] = Console.ReadLine();



            Console.WriteLine("Enter the State");
            state = Console.ReadLine();


            Console.WriteLine("Enter the Zip Code");
            zipCode = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the Phone Number");

            phoneNumber = Convert.ToInt64(Console.ReadLine());


            Console.WriteLine("Enter the Email");
            email = Console.ReadLine();

            ContactList contactList = new ContactList(firstName, lastName, address, state, zipCode, phoneNumber, email);


            this.addressBook.AddLast(contactList);


        }

        public void ContactDetails()  //Displaying contact details
        {

            if (addressBook.Count == 0)  //here checking in List there is contact or not  if no the lis is empty
            {
                Console.WriteLine("AddressBook is Empty");

            }
            else   //else it will display the details of contact person
            {
                foreach (ContactList contactList in this.addressBook)
                {
                    Console.WriteLine($"FirstName= {contactList.firstName} LastName= {contactList.lastName} Address= {contactList.address} state= {contactList.state} ZipCode= {contactList.zipCode} Phone= {contactList.phoneNumber} Email= {contactList.email}");

                }
            }

        }


        public void editContact()  //for editing the contact list
        {

            if (addressBook.Count == 0)   // here checking in List there is contact or not  if no the lis is empty
            {
                Console.WriteLine("AddressBook is Empty");

            }
            else  //else it will edit the contact details 
            {
                Console.WriteLine("enter the name which want to edit contact:");
                string name = Console.ReadLine();

                foreach (ContactList contactList in this.addressBook)
                {

                    if (contactList.firstName == name)
                    {
                        Console.WriteLine($"FirstName= {contactList.firstName} LastName= {contactList.lastName} Address= {contactList.address} state= {contactList.state} ZipCode= {contactList.zipCode} Phone= {contactList.phoneNumber} Email= {contactList.email}");
                        Console.WriteLine("\nthe {0} is present you can edit the details...", contactList.firstName);
                        Console.WriteLine("enter the details");

                        Console.WriteLine("Enter the First Name");
                        contactList.firstName = Console.ReadLine();

                        Console.WriteLine("Enter the Last Name");
                        contactList.lastName = Console.ReadLine();

                        Console.WriteLine("Enter the Adresss");
                        contactList.address[0] = Console.ReadLine();

                        Console.WriteLine("Enter the State");
                        contactList.state = Console.ReadLine();

                        Console.WriteLine("Enter the Zip Code");
                        contactList.zipCode = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter the Phone Number");
                        contactList.phoneNumber = Convert.ToInt64(Console.ReadLine());

                        Console.WriteLine("Enter the Email");
                        contactList.email = Console.ReadLine();

                        Console.WriteLine("updeted detalis List");
                        Console.WriteLine($"FirstName= {contactList.firstName} LastName= {contactList.lastName} Address= {contactList.address} state= {contactList.state} ZipCode= {contactList.zipCode} Phone= {contactList.phoneNumber} Email= {contactList.email}");

                    }
                    else
                    {

                        Console.WriteLine("the {0} is not present in ContactList", contactList.firstName);

                    }

                }
            }
        }

        public void removeContact()    // for removing the contact 
        {
            if (addressBook.Count == 0)      // here checking in List there is contact or not  if no the list is empty
            {
                Console.WriteLine("AddressBook is Empty");

            }
            else   // it will remove the contact from contact list
            {
                Console.WriteLine("enter the name you want to remove");
                string name = Console.ReadLine();

                foreach (ContactList contactList in this.addressBook)
                {

                    if (contactList.firstName == name)
                    {
                        addressBook.Remove(contactList);
                        break;

                    }
                    else
                    {
                        Console.WriteLine("the {0} is not present", contactList.firstName);

                    }
                }
            }
        }
    }
}
