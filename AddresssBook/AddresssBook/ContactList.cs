using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddresssBook
{
    internal class ContactList
    {
        public string firstName;
        public string lastName;
        public string[] address = new string[2];
        public string state;
        public int zipCode;
        public long phoneNumber;
        public string email;


        public ContactList(string firstName, string lastName, string[] address, string state, int zipCode, long phoneNumber, string email)
        {

            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.state = state;
            this.zipCode = zipCode;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
    }
}
