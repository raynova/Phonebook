using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    public class Contacts
    {
        public string name;
        public string lastName;
        public int phone;
        public string address;
        public string email;

        public Contacts(string name)
        {
            this.name = name;
            /*this.lastName = lastName;
            this.phone = phone;
            this.address = address;
            this.email = email;*/
        }
    }
}
