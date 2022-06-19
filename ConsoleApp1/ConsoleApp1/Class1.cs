using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AddressBook
    {
        public String firstName;
        public String lastName;
        public String address;
        public String city;
        public String state;
        public long zip;
        public long phoneNumber;
        public String email;

        static public void SetAddress()
        {

            AddressBook addressBook = new AddressBook();
            addressBook.firstName = "Aishwarya";
            addressBook.lastName = "Ganesan";
            addressBook.address = "ulwe";
            addressBook.city = "Mumbai";
            addressBook.state = "maharashtra";
            addressBook.zip = 410206;
            addressBook.phoneNumber = 9967900679;
            addressBook.email = "gaishwarya582gmail.com";
        }
    }
}
